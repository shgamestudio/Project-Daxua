using QUANLIBANHANG.DAL;
using QUANLIBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = QUANLIBANHANG.DTO.Menu;

namespace QUANLIBANHANG
{
    public partial class SellingManager : Form
    {
        private Accounts account;

        public Accounts Account
        { get => account;
            set
            {
                account = value;
            }
        }

        public SellingManager(Accounts loginaccount)
        {
           
            InitializeComponent();
            this.Account = loginaccount;
            LoadTable();
            LoadCatagory();
            isAdmin(account.KindOfAcc);
        }

        private void isAdmin( int type)
        {
            adminToolStripMenuItem.Enabled = (type == 1);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text += "(" + account.Name + ")";
        }

        public void LoadCatagory()
        {
            List<Category> catagories = CategoryDAL.Instance.GetCatagories();
            comboBox_Catagory.DataSource = catagories;
            comboBox_Catagory.DisplayMember = "NAME";
        }

        public void LoadFoodByCataIndex(int id)
        {
            List<Food> foods = FoodDAL.Instance.GetFoodsByCataInDex(id);
            comboBox_Food.DataSource = foods;
            comboBox_Food.DisplayMember = "NAME";
        }

        private void LoadTable()
        {
            if(flowLayoutPanel1!=null)
            {
                flowLayoutPanel1.Controls.Clear();
            }
            List<Table> tables = TableDAL.Instance.LoadTableList();
            foreach (Table table in tables)
            {
                Button button = new Button { Width = TableDAL.TableButtonWidth, Height = TableDAL.TableButtonHeigh };
                button.Text = table.Name + Environment.NewLine + table.Status;
                button.Click += Button_Click;
                button.Tag = table;//id ban
                switch(table.Status)
                {
                    case "TRỐNG":
                        button.BackColor = Color.Aqua;
                        break;
                    case "CÓ NGƯỜI":
                        button.BackColor = Color.LightPink;
                        break;
                }
                flowLayoutPanel1.Controls.Add(button);
            }
        }

        void ShowBill(int idTable)
        {
            int totalPrice=0;
            listView1.Items.Clear();
            List<Menu> menus = MenuDAL.Instance.GetMenus(idTable);
            foreach (Menu menu in menus)
            {
                ListViewItem listViewItem = new ListViewItem(menu.FoodName);
                listViewItem.SubItems.Add(menu.Price.ToString());
                listViewItem.SubItems.Add(menu.SoLuong.ToString());
                listViewItem.SubItems.Add(menu.TotalPrice.ToString());
                totalPrice += menu.TotalPrice;
                listView1.Items.Add(listViewItem);
            }
            CultureInfo cultureInfo = new CultureInfo("vn-VN");
            TextBox_TotalPrice.Text = totalPrice.ToString("C",cultureInfo);
            LoadTable();
        }
        private void Button_Click(object sender, EventArgs e)
        {

            int idTable = ((sender as Button).Tag as Table).ID;
            label_TableName.Text = ((sender as Button).Tag as Table).Name;
            listView1.Tag = (sender as Button).Tag;
            ShowBill(idTable);
        }

        private void thôngTinTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AccountInfo accountInfo = new AccountInfo(account);
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

        private void comboBox_Catagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 1;
            ComboBox cb = sender as ComboBox;
            if(cb.SelectedItem==null)
            {
                return;
            }
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodByCataIndex(id);
        }

        private void button_addFood_Click(object sender, EventArgs e)
        {
            if(listView1.Tag ==null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi chọn món", "Thông báo");
                return; 
            }
            Table table = listView1.Tag as Table;
            int idbill = BillDAL.Instance.GetUnCheckOutBillByTableId(table.ID);
            int idFood = (int)(comboBox_Food.SelectedItem as Food).ID;
            int soluong = (int)numeric_SoLuong.Value;
                
            if(idbill==-1)
            {
                BillDAL.Instance.InsertValueBill(table.ID);
                BillInfoDAL.Instance.InsertValueBillInfo(BillDAL.Instance.GetMaxBillIndex(), idFood, soluong);            }
            else
            {

                BillInfoDAL.Instance.InsertValueBillInfo(idbill, idFood, soluong);
            }
            ShowBill(table.ID);
            LoadTable();
        }

        private void Button_Pay_Click(object sender, EventArgs e)
        {
            Table id = listView1.Tag as Table;
            if(id==null)
            {
                MessageBox.Show("Vui lòng chọn bàn và thêm món ăn", "Thông báo");
                return;
            }
            int idBill = BillDAL.Instance.GetUnCheckOutBillByTableId(id.ID);
            if(idBill!=-1)
            {
                if(MessageBox.Show("Bạn Có Chắc Thêm Hóa Đơn Cho Bàn"+id.Name,"Thông Báo",MessageBoxButtons.OKCancel)==DialogResult.OK)
                {
                    BillDAL.Instance.Paid(idBill);
                    ShowBill(id.ID);
                }
            }
        }
    }
}
