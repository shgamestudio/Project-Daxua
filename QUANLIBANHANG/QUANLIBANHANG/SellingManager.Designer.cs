namespace QUANLIBANHANG
{
    partial class SellingManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numeric_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.button_addFood = new System.Windows.Forms.Button();
            this.comboBox_Food = new System.Windows.Forms.ComboBox();
            this.comboBox_Catagory = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Button_Pay = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.TextBox_TotalPrice = new System.Windows.Forms.TextBox();
            this.label_TableName = new System.Windows.Forms.Label();
            this.button_saleOff = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_SoLuong)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem1,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông Tin Tài Khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem1
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem1.Name = "thôngTinTàiKhoảnToolStripMenuItem1";
            this.thôngTinTàiKhoảnToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.thôngTinTàiKhoảnToolStripMenuItem1.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem1.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem1_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(318, 411);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numeric_SoLuong);
            this.panel1.Controls.Add(this.button_addFood);
            this.panel1.Controls.Add(this.comboBox_Food);
            this.panel1.Controls.Add(this.comboBox_Catagory);
            this.panel1.Location = new System.Drawing.Point(347, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 57);
            this.panel1.TabIndex = 2;
            // 
            // numeric_SoLuong
            // 
            this.numeric_SoLuong.Location = new System.Drawing.Point(328, 18);
            this.numeric_SoLuong.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numeric_SoLuong.Name = "numeric_SoLuong";
            this.numeric_SoLuong.Size = new System.Drawing.Size(71, 20);
            this.numeric_SoLuong.TabIndex = 3;
            this.numeric_SoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_addFood
            // 
            this.button_addFood.Location = new System.Drawing.Point(246, 4);
            this.button_addFood.Name = "button_addFood";
            this.button_addFood.Size = new System.Drawing.Size(75, 48);
            this.button_addFood.TabIndex = 2;
            this.button_addFood.Text = "Thêm";
            this.button_addFood.UseVisualStyleBackColor = true;
            this.button_addFood.Click += new System.EventHandler(this.button_addFood_Click);
            // 
            // comboBox_Food
            // 
            this.comboBox_Food.FormattingEnabled = true;
            this.comboBox_Food.Location = new System.Drawing.Point(4, 31);
            this.comboBox_Food.Name = "comboBox_Food";
            this.comboBox_Food.Size = new System.Drawing.Size(235, 21);
            this.comboBox_Food.TabIndex = 1;
            // 
            // comboBox_Catagory
            // 
            this.comboBox_Catagory.FormattingEnabled = true;
            this.comboBox_Catagory.Location = new System.Drawing.Point(4, 4);
            this.comboBox_Catagory.Name = "comboBox_Catagory";
            this.comboBox_Catagory.Size = new System.Drawing.Size(235, 21);
            this.comboBox_Catagory.TabIndex = 0;
            this.comboBox_Catagory.SelectedIndexChanged += new System.EventHandler(this.comboBox_Catagory_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(347, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 285);
            this.panel2.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(441, 285);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món Ăn";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Lượng";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 90;
            // 
            // Button_Pay
            // 
            this.Button_Pay.Location = new System.Drawing.Point(689, 382);
            this.Button_Pay.Name = "Button_Pay";
            this.Button_Pay.Size = new System.Drawing.Size(99, 48);
            this.Button_Pay.TabIndex = 4;
            this.Button_Pay.Text = "Thanh Toán";
            this.Button_Pay.UseVisualStyleBackColor = true;
            this.Button_Pay.Click += new System.EventHandler(this.Button_Pay_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Enabled = false;
            this.numericUpDown3.Location = new System.Drawing.Point(399, 416);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(95, 20);
            this.numericUpDown3.TabIndex = 8;
            // 
            // TextBox_TotalPrice
            // 
            this.TextBox_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_TotalPrice.Location = new System.Drawing.Point(553, 383);
            this.TextBox_TotalPrice.Name = "TextBox_TotalPrice";
            this.TextBox_TotalPrice.ReadOnly = true;
            this.TextBox_TotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBox_TotalPrice.Size = new System.Drawing.Size(130, 26);
            this.TextBox_TotalPrice.TabIndex = 10;
            this.TextBox_TotalPrice.Text = "0";
            // 
            // label_TableName
            // 
            this.label_TableName.AutoSize = true;
            this.label_TableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TableName.Location = new System.Drawing.Point(593, 416);
            this.label_TableName.Name = "label_TableName";
            this.label_TableName.Size = new System.Drawing.Size(13, 20);
            this.label_TableName.TabIndex = 11;
            this.label_TableName.Text = ".";
            // 
            // button_saleOff
            // 
            this.button_saleOff.Enabled = false;
            this.button_saleOff.Location = new System.Drawing.Point(395, 384);
            this.button_saleOff.Name = "button_saleOff";
            this.button_saleOff.Size = new System.Drawing.Size(99, 26);
            this.button_saleOff.TabIndex = 5;
            this.button_saleOff.Text = "Giảm Giá";
            this.button_saleOff.UseVisualStyleBackColor = true;
            // 
            // SellingManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_TableName);
            this.Controls.Add(this.TextBox_TotalPrice);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.button_saleOff);
            this.Controls.Add(this.Button_Pay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SellingManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_SoLuong)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_Catagory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.NumericUpDown numeric_SoLuong;
        private System.Windows.Forms.Button button_addFood;
        private System.Windows.Forms.ComboBox comboBox_Food;
        private System.Windows.Forms.Button Button_Pay;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox TextBox_TotalPrice;
        private System.Windows.Forms.Label label_TableName;
        private System.Windows.Forms.Button button_saleOff;
    }
}