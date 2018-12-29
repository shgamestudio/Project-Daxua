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
            if ((MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát ?", "Thông báo", MessageBoxButtons.OKCancel)) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SellingManager sellingManager = new SellingManager();
            this.Hide();
            sellingManager.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
