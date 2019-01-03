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
    public partial class Function : Form
    {
        public Function()
        {
            InitializeComponent();
        }

        private void Funtion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel)) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox_UserName.Text;
            string passWord = textBox_UserPassword.Text;
            
            if (Login(userName,passWord))
            {
                Accounts accounts = AccDAL.Instance.GetAccountByUserName(userName);
                SellingManager sellingManager = new SellingManager(accounts);
                this.Hide();
                sellingManager.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn nhập Sai tên tài khoản hoặc mật khẩu.");
            }
            this.textBox_UserName.Clear();
            this.textBox_UserPassword.Clear();
        }

        bool Login(string userName,string passWord)
        {
            return AccDAL.Instance.Login(userName, passWord);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Exit_MouseEnter(object sender, EventArgs e)
        {
            Button_Exit.Image = Properties.Resources.thoatexit2;
        }

        private void Button_Exit_MouseLeave(object sender, EventArgs e)
        {
            Button_Exit.Image = Properties.Resources.thoatexit1;
        }

        private void Button_Sign_In_MouseEnter(object sender, EventArgs e)
        {
            Button_Sign_In.Image = Properties.Resources.thoatexit2;
        }

        private void Button_Sign_In_MouseLeave(object sender, EventArgs e)
        {
            Button_Sign_In.Image = Properties.Resources.thoatexit1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Phần mềm được tạo bởi SH Studio, liên hệ : 17520982@gm.uit.edu.vn hoặc 17520511@gm.uit.edu.vn để đóng góp ý kiến", "Thông báo");
        }
    }
}
