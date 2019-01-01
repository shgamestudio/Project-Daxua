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
using System.Media;
using System.Drawing.Printing;

namespace QUANLIBANHANG
{
    public partial class SellingManager : Form
    {
        private Accounts account;
        private SoundPlayer _soundPlayer_pay;

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

            _soundPlayer_pay = new SoundPlayer("pay.wav");
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
                        button.BackColor = Color.SpringGreen;
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
            accountInfo.UpdateAccount += AccountInfo_UpdateAccount;
            accountInfo.ShowDialog();
        }

        private void AccountInfo_UpdateAccount(object sender, AccountInfo.AccountEvent e)
        {
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản ("+e.Acc.UserName+")";
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.loginacc = this.account;
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
            if (id == null)
            {
                MessageBox.Show("Vui lòng chọn bàn và thêm món ăn", "Thông báo");
                return;
            }
            if (id.Status == "CÓ NGƯỜI")
            {

                int idBill = BillDAL.Instance.GetUnCheckOutBillByTableId(id.ID);
                if (idBill != -1)
                {
                    if (MessageBox.Show("Bạn Có Chắc Thêm Hóa Đơn Cho " + id.Name, "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        BillDAL.Instance.Paid(idBill);
                        ShowBill(id.ID);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Món Ăn Trước Khi Thanh Toán", "Thông Báo");
            }
        }

        private void button_PrintRecipe_Click(object sender, EventArgs e)
        {
            Table id = listView1.Tag as Table;
            if (id == null)
            {
                MessageBox.Show("Vui lòng chọn bàn và thêm món ăn", "Thông báo");
                return;
            }
            if (id.Status != "CÓ NGƯỜI")
            {
                int idBill = BillDAL.Instance.GetUnCheckOutBillByTableId(id.ID);
                if (idBill != -1)
                if(MessageBox.Show("Bạn Có Chắc Thêm Hóa Đơn Cho "+id.Name,"Thông Báo",MessageBoxButtons.OKCancel)==DialogResult.OK)

                {
                    if (MessageBox.Show("Bạn Có Chắc Thêm Hóa Đơn Cho " + id.Name, "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        BillDAL.Instance.Paid(idBill);

                    }
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Món Ăn Trước Khi Thanh Toán", "Thông Báo");
                return;
            }
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument; //add the document to the dialog box...        

            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.
            this.Hide();
            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();

            }
            ShowBill(id.ID);
            this.Show();
        }

        private void CreateReceipt(object sender, PrintPageEventArgs e)
        {

            //this prints the reciept

            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString(" SH Restaurants", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            string top = "Tên Món Ăn".PadRight(20) + "Giá".PadRight(15) + "Số Lượng".PadRight(10) + "Tổng Tiền";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("----------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent


            string totalprice = TextBox_TotalPrice.Text;

            foreach (ListViewItem item in listView1.Items)
            {
                //create the string to print on the reciept
                string FoodName = item.SubItems[0].Text;
                string Price = item.SubItems[1].Text;
                string Count = item.SubItems[2].Text;
                string TotalPriceByFood = item.SubItems[3].Text;

                string productLine = FoodName.PadRight(20) + Price.PadRight(15) + Count.PadRight(10) + TotalPriceByFood;

                graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);

                offset = offset + (int)fontHeight + 5; //make the spacing consistent
                //}

            }

            offset = offset + 30;
            graphic.DrawString("----------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 30;
            graphic.DrawString("Total to pay ".PadRight(45) + totalprice, new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 30; //make some room so that the total stands out.

            graphic.DrawString("     Cảm Ơn Quý Khách,", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("       Hẹn Gặp Lại", font, new SolidBrush(Color.Black), startX, startY + offset);

        }
    }

}
