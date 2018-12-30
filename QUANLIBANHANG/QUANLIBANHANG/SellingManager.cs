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
    public partial class SellingManager : Form
    {
        public SellingManager()
        {
            InitializeComponent();
            LoadTable();
            
        }

        private void LoadTable()
        {
            List<Table> tables = TableDAL.Instance.LoadTableList();
            foreach (Table table in tables)
            {
                Button button = new Button { Width = TableDAL.TableButtonWidth, Height = TableDAL.TableButtonHeigh };
                button.Text = table.Name + Environment.NewLine + table.Status;
                switch(table.Status)
                {
                    case "Trong":
                        button.BackColor = Color.Aqua;
                        break;
                    case "Co Nguoi":
                        button.BackColor = Color.LightPink;
                        break;
                }
                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void thôngTinTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AccountInfo accountInfo = new AccountInfo();
            accountInfo.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
