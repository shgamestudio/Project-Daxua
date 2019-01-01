using QUANLIBANHANG.DAL;
using QUANLIBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLIBANHANG
{
    public partial class Admin : Form
    {
        BindingSource bindingFood = new BindingSource();
        BindingSource bindingAcc = new BindingSource();
        BindingSource bindingCate = new BindingSource();
        public Accounts loginacc;
        public Admin()
        {
            InitializeComponent();

            //acc
            dataGridView_Acc.DataSource = bindingAcc;
            addBindingAcc();
            loadAccList();

            //bills
            LoadBillsByDate(dateTimePicker_DateFrom.Value, dateTimePicker_DateTo.Value);


            //food
            dataGridView_Food.DataSource = bindingFood;
            LoadFood();
            addFoodBinding();

            //Cata
            dataGridView_Cata.DataSource = bindingCate;
            addCateBinding();
            LoadCate();
            LoadCataIntoFoodCB(comboBox_foodCata);


        }
        private string FixNameFormat(string input)
        {
            input = input.ToLower();
            input = " " + input;
            foreach (Match m in Regex.Matches(input, @"\s\S"))
            {
                input = input.Replace(m.Value, m.Value.ToUpper());
            }
            return input.Substring(1);
        }

        #region Category
        private void LoadCate()
        {
            bindingCate.DataSource = CategoryDAL.Instance.GetCatagories();
        }

        private void addCateBinding()
        {
            textBox_cataID.DataBindings.Add(new Binding("Text",dataGridView_Cata.DataSource,"ID", true, DataSourceUpdateMode.Never));
            textBox_NameCata.DataBindings.Add(new Binding("Text",dataGridView_Cata.DataSource,"NAME", true, DataSourceUpdateMode.Never));
        }

        private void insertCate(string name)
        {
            if (CategoryDAL.Instance.InsertCate(name))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                LoadCate();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thực hiện", "Thông báo");
            }
            LoadCate();
        }

        private void editCate(int id, string name)
        {
            if (CategoryDAL.Instance.EditCate(id,name))
            {
                MessageBox.Show("Sửa thành công", "Thông báo");
                LoadCate();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thực hiện", "Thông báo");
            }
            LoadCate();
        }
        private void deleteCate(int id)
        {
            if (CategoryDAL.Instance.DeleteCateByID(id))
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                LoadCate();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thực hiện", "Thông báo");
            }
            LoadCate();
        }
        private bool isExistCata(string name)
        {
            LoadCate();
            int temp = dataGridView_Cata.RowCount;
            for (int i = 0; i < temp; i++)
            {
                if (name == (dataGridView_Cata[1, i].Value.ToString()))
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region Food
        private void LoadCataIntoFoodCB(ComboBox comboBox_foodCata)//load Cata vao Food CB
        {
            comboBox_foodCata.DataSource = CategoryDAL.Instance.GetCatagories();
            comboBox_foodCata.DisplayMember = "Name";
        }

        private void addFoodBinding()
        {

            textBox_IDFood.DataBindings.Add(new Binding("Text", dataGridView_Food.DataSource, "ID",true,DataSourceUpdateMode.Never));
            textBox_foodName.DataBindings.Add(new Binding("Text", dataGridView_Food.DataSource, "NAME", true, DataSourceUpdateMode.Never));
            numericUpDown__Price.DataBindings.Add(new Binding("Value", dataGridView_Food.DataSource, "PRICE", true, DataSourceUpdateMode.Never));
        }

        private void LoadFood()
        {
            bindingFood.DataSource = FoodDAL.Instance.GetFoods();
        }

        private void addFood(string name, int cataid, int price)
        {
            if (FoodDAL.Instance.InsertFood(name, cataid, price))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                LoadFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thực hiện", "Thông báo");
            }
        }

        private void editFood(int ID, string name, int cateid, int price)
        {
            if (FoodDAL.Instance.EditFood(ID, name, cateid, price))
            {
                MessageBox.Show("Sửa Thành Công", "Thông báo");
                LoadFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thực hiện", "Thông báo");
            }
        }

        private void delFood(int ID)
        {
            if (FoodDAL.Instance.DeleteFoodByID(ID))
            {
                MessageBox.Show("Xóa Thành Công", "Thông báo");
                LoadFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thực hiện", "Thông báo");
            }
        }

        private bool isExistFood(string name)
        {
            LoadFood();
            int temp = dataGridView_Food.RowCount;
            for (int i = 0; i < temp; i++)
            {
                if (name == (dataGridView_Food[1, i].Value.ToString()))
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region Acc
        private void loadAccList()
        {
            bindingAcc.DataSource = AccDAL.Instance.GetAccounts();
        }
        private void addBindingAcc()
        {
            textBox_UserName.DataBindings.Add(new Binding("Text", dataGridView_Acc.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            textBox_Name.DataBindings.Add(new Binding("Text", dataGridView_Acc.DataSource, "Name", true, DataSourceUpdateMode.Never));
            numericUpDown_KindOfAcc.DataBindings.Add(new Binding("Value", dataGridView_Acc.DataSource, "KindOfAcc", true, DataSourceUpdateMode.Never));
        }

        #endregion

        #region METHORACC
        private void LoadBillsByDate(DateTime datein,DateTime dateout)
        {
            dataGridView_Bills.DataSource = BillDAL.Instance.GetBillsByDate(datein, dateout);
        }

        private void InsertAcc( string UserName,string Name,int KindOfAcc)
        {
            if (isExistUserName(UserName) == false)
            {
                MessageBox.Show("UserName đã tồn tại, vui lòng chọn UserName khác", "Thông Báo");
                return;
            }
            if(AccDAL.Instance.InsertAcc(UserName, Name, KindOfAcc))
            {
                MessageBox.Show("Thêm tài khoản thành công với Mật Khẩu mặc định là 0, Vui lòng đăng nhập bằng tài khoản để đổi mật khẩu mới", "Thông báo");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra", "Thông Báo");
            }
            loadAccList();
        }
        private void EditAcc(string UserName, string Name, int KindOfAcc)
        {
            if (MessageBox.Show("Bạn sẽ không sửa được UserName", "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (AccDAL.Instance.EditAcc(UserName, Name, KindOfAcc))
                {
                    MessageBox.Show("Sửa tài khoản thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra", "Thông Báo");
                }
                loadAccList();
            }
        }
        private bool isExistUserName(string UserName)
        {
            loadAccList();
            int temp = dataGridView_Acc.RowCount;
            for(int i=0;i<temp;i++)
            {
                if (UserName==(dataGridView_Acc[0,i].Value.ToString()))
                {
                    return false;
                }
            }
            return true;
        }
         
        private void DeleteAcc(string UserName)
        {
            if(loginacc.UserName==UserName)
            {
                MessageBox.Show("Bạn Không Thể Xóa Tài Khoản Chính Mình hoặc Tài Khoản ADMIN", "Thông Báo");
                return;
            }
            if (AccDAL.Instance.DeleteAccByUserName(UserName))
            {
                MessageBox.Show("Xóa tài khoản thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra", "Thông Báo");
            }
            loadAccList();
        }

        private void ResetPass(string UserName)
        {
            if (AccDAL.Instance.ResetPassByUserName(UserName))
            {
                MessageBox.Show("Đặt lại tài khoản thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra", "Thông Báo");
            }
            loadAccList();
        }

       

        #endregion

        #region EVENTS
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

        private void button_addFood_Click(object sender, EventArgs e)
        {
            string name = textBox_foodName.Text;
            name = FixNameFormat(name);
            int cataid = (comboBox_foodCata.SelectedItem as Category).ID;
            int price = (int)numericUpDown__Price.Value;
            if(isExistFood(name))
            {
                addFood(name, cataid, price);
            }
            else
            { MessageBox.Show("Món Đã Tồn Tại", "Thông Báo"); }
        }

        private void button_changeFood_Click(object sender, EventArgs e)
        {
            
            int ID = Convert.ToInt32(textBox_IDFood.Text);
            string name = textBox_foodName.Text;
            int cateid = (comboBox_foodCata.SelectedItem as Category).ID;
            int price = (int)numericUpDown__Price.Value;
            editFood(ID, name, cateid, price);
            
        }

        private void button_deleteFood_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa thức ăn này sẽ đồng nghĩa với Xóa mọi bill liên quan đến thức ăn đó", "Cảnh Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int ID = Convert.ToInt32(textBox_IDFood.Text);
                delFood(ID);
            }
        }

       
        private void button_viewAcc_Click(object sender, EventArgs e)
        {
            loadAccList();
        }

        private void button_addAcc_Click(object sender, EventArgs e)
        {
            string UserName = textBox_UserName.Text;
            string Name = textBox_Name.Text;
            int kindOfAcc = (int)numericUpDown_KindOfAcc.Value;
            InsertAcc(UserName, Name, kindOfAcc);
        }

        private void button_deleAcc_Click(object sender, EventArgs e)
        {
            string UserName = textBox_UserName.Text;
            DeleteAcc(UserName);
        }

        private void button_editAcc_Click(object sender, EventArgs e)
        {
            string UserName = textBox_UserName.Text;
            string Name = textBox_Name.Text;
            int kindOfAcc = (int)numericUpDown_KindOfAcc.Value;
            EditAcc(UserName, Name, kindOfAcc);
        }

        private void button_ResetPass_Click(object sender, EventArgs e)
        {
            string UserName = textBox_UserName.Text;
            ResetPass(UserName);
        }

        private void button_CataView_Click(object sender, EventArgs e)
        {
            LoadCate();
        }

        private void button_cataAdd_Click(object sender, EventArgs e)
        {
            string name = textBox_NameCata.Text;
            name = FixNameFormat(name);
            if(isExistCata(name))
            {
                insertCate(name);
            }
            else
            {
                MessageBox.Show("Trùng Tên", "Thông Báo");
            }
            
        }

        private void button_cataDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa Danh Mục này đồng nghĩa xóa tất cả món ăn thuộc Danh Mục này", "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int temp = Convert.ToInt32(textBox_cataID.Text);
                deleteCate(temp);
            }
        }

        private void button_cataEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_cataID.Text);
            string name = textBox_NameCata.Text;
            editCate(id, name);
        }


        #endregion


    }
}
