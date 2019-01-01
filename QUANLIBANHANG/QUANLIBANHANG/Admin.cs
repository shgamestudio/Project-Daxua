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
        BindingSource binding = new BindingSource();
        public Admin()
        {
            InitializeComponent();

            dataGridView_Food.DataSource = binding;
            loadAccList();
            LoadBillsByDate(dateTimePicker_DateFrom.Value, dateTimePicker_DateTo.Value);
            LoadFood();
            addFoodBinding();
            LoadCataIntoFoodCB(comboBox_foodCata);
        }

        private void LoadCataIntoFoodCB(ComboBox comboBox_foodCata)
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
            binding.DataSource = FoodDAL.Instance.GetFoods();
        }

        void loadAccList()
        {
            string query = "SELECT USERNAME as[Tên Tài Khoản],NAME as[Tên Hiển Thị], KINDOFACC as[Loại Tài Khoản] FROM ACCOUNT";
            dataGridView_Acc.DataSource =DataProvider.Instance.ExcuteQuery(query);
        }

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
    }
}
