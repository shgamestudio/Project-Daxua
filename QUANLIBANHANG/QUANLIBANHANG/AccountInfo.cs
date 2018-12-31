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
    public partial class AccountInfo : Form
    {
        private Accounts accounts;

        public AccountInfo(Accounts account)
        {
            InitializeComponent();
            this.accounts = account;
            DisplayAccount(account);
        }

        private void DisplayAccount(Accounts accounts)
        {
            this.textBox_DisplayName.Text = accounts.Name;
            this.textBox_NameUser.Text = accounts.UserName;
        }
    
        private void EditAccount()
        {
            string name = textBox_DisplayName.Text;
            string username = textBox_NameUser.Text;
            string password = textBox_OldPass.Text;
            string newpassword = textBox_newPass.Text;
            string renewpassword = textBox_newPassAgain.Text;
            if(!newpassword.Equals(renewpassword))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới giống nhau", "Thông báo");
                return;
            }
            else
            {
                
                if (AccDAL.Instance.EditAcc(username,name, password,newpassword))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông Báo");
                    if(updateAccount !=null)
                    {
                        updateAccount(this, new AccountEvent(AccDAL.Instance.GetAccountByUserName(username)));
                    }
                }
                else
                {
                    MessageBox.Show("Vui Lòng Nhập Đúng Mật Khẩu", "Thông Báo");
                }
            }

        }

        public Accounts Accounts { get => accounts; set => accounts = value; }

        private void button_Changedpass_Click(object sender, EventArgs e)
        {
            EditAccount();
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }

        }
        public class AccountEvent :EventArgs
        {
            private Accounts accounts;
            public Accounts Acc
            {
                get { return accounts; }
                set
                {
                    accounts = value;
                }
            }

            public AccountEvent (Accounts acc)
            {
                this.accounts = acc;
            }
        }
    }
}
