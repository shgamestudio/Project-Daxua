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
        }

        void loadAccList()
        {
            string query = "SELECT USERNAME as[Tên Tài Khoản],NAME as[Tên Hiển Thị], KINDOFACC as[Loại Tài Khoản] FROM ACCOUNT";
            dataGridView_Acc.DataSource =DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
