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

            textBox_IDFood.DataBindings.Add(new Binding("Text", dataGridView_Food.DataSource, "ID"));
            textBox_foodName.DataBindings.Add(new Binding("Text", dataGridView_Food.DataSource, "NAME"));
            numericUpDown__Price.DataBindings.Add(new Binding("Value", dataGridView_Food.DataSource, "PRICE"));
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
    }
}
