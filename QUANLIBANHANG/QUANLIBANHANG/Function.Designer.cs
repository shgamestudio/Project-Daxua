namespace QUANLIBANHANG
{
    partial class Function
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Function));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Button_Sign_In = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_UserPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(130, 48);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(166, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Quản Lý Bán Hàng";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Enabled = false;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(130, 73);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(123, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Quản Lý Kho";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // Button_Sign_In
            // 
            this.Button_Sign_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Sign_In.ForeColor = System.Drawing.Color.White;
            this.Button_Sign_In.Image = global::QUANLIBANHANG.Properties.Resources.thoatexit1;
            this.Button_Sign_In.Location = new System.Drawing.Point(203, 167);
            this.Button_Sign_In.Name = "Button_Sign_In";
            this.Button_Sign_In.Size = new System.Drawing.Size(93, 34);
            this.Button_Sign_In.TabIndex = 2;
            this.Button_Sign_In.Text = "Đăng nhập";
            this.Button_Sign_In.UseVisualStyleBackColor = true;
            this.Button_Sign_In.Click += new System.EventHandler(this.button1_Click);
            this.Button_Sign_In.MouseEnter += new System.EventHandler(this.Button_Sign_In_MouseEnter);
            this.Button_Sign_In.MouseLeave += new System.EventHandler(this.Button_Sign_In_MouseLeave);
            // 
            // Button_Exit
            // 
            this.Button_Exit.FlatAppearance.BorderSize = 0;
            this.Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Exit.ForeColor = System.Drawing.Color.White;
            this.Button_Exit.Image = ((System.Drawing.Image)(resources.GetObject("Button_Exit.Image")));
            this.Button_Exit.Location = new System.Drawing.Point(332, 9);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(84, 30);
            this.Button_Exit.TabIndex = 3;
            this.Button_Exit.Text = "Thoát";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.button2_Click);
            this.Button_Exit.MouseEnter += new System.EventHandler(this.Button_Exit_MouseEnter);
            this.Button_Exit.MouseLeave += new System.EventHandler(this.Button_Exit_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_UserName.Location = new System.Drawing.Point(134, 109);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(229, 20);
            this.textBox_UserName.TabIndex = 6;
            // 
            // textBox_UserPassword
            // 
            this.textBox_UserPassword.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_UserPassword.Location = new System.Drawing.Point(134, 133);
            this.textBox_UserPassword.Name = "textBox_UserPassword";
            this.textBox_UserPassword.PasswordChar = '*';
            this.textBox_UserPassword.Size = new System.Drawing.Size(229, 20);
            this.textBox_UserPassword.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(5, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Chọn mục quản lý:";
            // 
            // Function
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(428, 213);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_UserPassword);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Sign_In);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Function";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Funtion_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button Button_Sign_In;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_UserPassword;
        private System.Windows.Forms.Label label3;
    }
}

