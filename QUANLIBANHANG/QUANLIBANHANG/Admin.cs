using QUANLIBANHANG.DAL;
using QUANLIBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLIBANHANG
{
    public partial class Admin : Form
    {
        BindingSource bindingFood = new BindingSource();
        BindingSource bindingAcc = new BindingSource();
        public Admin()
        {
            InitializeComponent();

            //acc
            dataGridView_Acc.DataSource = bindingAcc;
            addBindingAcc();
            loadAccList();

            //bills

            LoadBillsByDate(dateTimePicker_DateFrom.Value, dateTimePicker_DateTo.Value);
            //food
            dataGridView_Food.DataSource = bindingFood;
            LoadFood();
            addFoodBinding();

            //Cata
            LoadCataIntoFoodCB(comboBox_foodCata);
        }


        #region Food
        private void LoadCataIntoFoodCB(ComboBox comboBox_foodCata)//load Cata vao Food CB
        {
            comboBox_foodCata.DataSource = CategoryDAL.Instance.GetCatagories();
            comboBox_foodCata.DisplayMember = "Name";
        }

        private void addFoodBinding()
        {

            textBox_IDFood.DataBindings.Add(new Binding("Text", dataGridView_Food.DataSource, "ID",true,DataSourceUpdateMode.Never));
            textBox_foodName.DataBindings.Add(new Binding("Text", dataGridView_Food.DataSource, "NAME", true, DataSourceUpdateMode.Never));
            numericUpDown__Price.DataBindings.Add(new Binding("Value", dataGridView_Food.DataSource, "PRICE", true, DataSourceUpdateMode.Never));
        }

        private void LoadFood()
        {
            bindingFood.DataSource = FoodDAL.Instance.GetFoods();
        }
        #endregion


        #region Acc
        private void loadAccList()
        {
            bindingAcc.DataSource = AccDAL.Instance.GetAccounts();
        }
        private void addBindingAcc()
        {
            textBox_UserName.DataBindings.Add(new Binding("Text", dataGridView_Acc.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            textBox_Name.DataBindings.Add(new Binding("Text", dataGridView_Acc.DataSource, "Name", true, DataSourceUpdateMode.Never));
            textBox_kindOfAcc.DataBindings.Add(new Binding("Text", dataGridView_Acc.DataSource, "KindOfAcc", true, DataSourceUpdateMode.Never));
        }

        #endregion
        void LoadBillsByDate(DateTime datein,DateTime dateout)
        {
            dataGridView_Bills.DataSource = BillDAL.Instance.GetBillsByDate(datein, dateout);
        }

        private void button_List_Click(object sender, EventArgs e)
        {
            LoadBillsByDate(dateTimePicker_DateFrom.Value, dateTimePicker_DateTo.Value);
        }

        private void button_viewFood_Click(object sender, EventArgs e)
        {
           
            LoadFood();
        }

        private void textBox_IDFood_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView_Food.SelectedCells.Count>0)
            {
                int id = (int)dataGridView_Food.SelectedCells[0].OwningRow.Cells["IDCata"].Value;
                Category category = CategoryDAL.Instance.GetCategoryByID(id);
                comboBox_foodCata.SelectedItem = category;
                int index = -1;
                int temp = 0;
                foreach (Category item in comboBox_foodCata.Items)
                {
                    if(item.ID==category.ID)
                    {
                        index = temp;
                        break;
                    }
                    temp++;
                }
                comboBox_foodCata.SelectedIndex = index;
            }
        }

        private void button_addFood_Click(object sender, EventArgs e)
        {
            string name = textBox_foodName.Text;
            int cataid = (comboBox_foodCata.SelectedItem as Category).ID;
            int price = (int)numericUpDown__Price.Value;
            if(FoodDAL.Instance.InsertFood(name,cataid,price))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                LoadFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thực hiện", "Thông báo");
            }
        }

        private void button_changeFood_Click(object sender, EventArgs e)
        {
            
            int ID = Convert.ToInt32(textBox_IDFood.Text);
            string name = textBox_foodName.Text;
            int cataid = (comboBox_foodCata.SelectedItem as Category).ID;
            int price = (int)numericUpDown__Price.Value;
            if (FoodDAL.Instance.EditFood(ID,name, cataid, price))
            {
                MessageBox.Show("Sửa Thành Công", "Thông báo");
                LoadFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thực hiện", "Thông báo");
            }
        }

        private void button_deleteFood_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox_IDFood.Text);
            if (FoodDAL.Instance.DeleteFoodByID(ID))
            {
                MessageBox.Show("Xóa Thành Công", "Thông báo");
                LoadFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thực hiện", "Thông báo");
            }
        }

       
        private void button_viewAcc_Click(object sender, EventArgs e)
        {
            loadAccList();
        }
    }
}
