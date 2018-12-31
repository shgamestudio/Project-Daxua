using QUANLIBANHANG.DAL;
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
        public Admin()
        {
            InitializeComponent();

            loadAccList();
            LoadBillsByDate(dateTimePicker_DateFrom.Value, dateTimePicker_DateTo.Value);
            LoadFood();
        }

        private void LoadFood()
        {
            dataGridView_Food.DataSource = FoodDAL.Instance.GetFoods();
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
    }
}
