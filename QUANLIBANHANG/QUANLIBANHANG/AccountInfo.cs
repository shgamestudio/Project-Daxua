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
            EditAccount(account);
        }

        private void EditAccount(Accounts accounts)
        {
            this.textBox_DisplayName.Text = accounts.Name;
            this.textBox_NameUser.Text = accounts.UserName;
        }
    
        public Accounts Accounts { get => accounts; set => accounts = value; }
    }
}
