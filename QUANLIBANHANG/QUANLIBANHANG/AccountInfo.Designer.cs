namespace QUANLIBANHANG
{
    partial class AccountInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_DisplayName = new System.Windows.Forms.TextBox();
            this.textBox_NameUser = new System.Windows.Forms.TextBox();
            this.textBox_OldPass = new System.Windows.Forms.TextBox();
            this.textBox_newPass = new System.Windows.Forms.TextBox();
            this.textBox_newPassAgain = new System.Windows.Forms.TextBox();
            this.button_Changedpass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Hiển Thị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhập lại mật khẩu mới";
            // 
            // textBox_DisplayName
            // 
            this.textBox_DisplayName.Location = new System.Drawing.Point(506, 41);
            this.textBox_DisplayName.Name = "textBox_DisplayName";
            this.textBox_DisplayName.Size = new System.Drawing.Size(178, 20);
            this.textBox_DisplayName.TabIndex = 5;
            // 
            // textBox_NameUser
            // 
            this.textBox_NameUser.Location = new System.Drawing.Point(506, 68);
            this.textBox_NameUser.Name = "textBox_NameUser";
            this.textBox_NameUser.Size = new System.Drawing.Size(178, 20);
            this.textBox_NameUser.TabIndex = 6;
            // 
            // textBox_OldPass
            // 
            this.textBox_OldPass.Location = new System.Drawing.Point(506, 94);
            this.textBox_OldPass.Name = "textBox_OldPass";
            this.textBox_OldPass.Size = new System.Drawing.Size(178, 20);
            this.textBox_OldPass.TabIndex = 7;
            // 
            // textBox_newPass
            // 
            this.textBox_newPass.Location = new System.Drawing.Point(506, 122);
            this.textBox_newPass.Name = "textBox_newPass";
            this.textBox_newPass.Size = new System.Drawing.Size(178, 20);
            this.textBox_newPass.TabIndex = 8;
            // 
            // textBox_newPassAgain
            // 
            this.textBox_newPassAgain.Location = new System.Drawing.Point(506, 151);
            this.textBox_newPassAgain.Name = "textBox_newPassAgain";
            this.textBox_newPassAgain.Size = new System.Drawing.Size(178, 20);
            this.textBox_newPassAgain.TabIndex = 9;
            // 
            // button_Changedpass
            // 
            this.button_Changedpass.Location = new System.Drawing.Point(609, 207);
            this.button_Changedpass.Name = "button_Changedpass";
            this.button_Changedpass.Size = new System.Drawing.Size(75, 23);
            this.button_Changedpass.TabIndex = 10;
            this.button_Changedpass.Text = "Đổi";
            this.button_Changedpass.UseVisualStyleBackColor = true;
            this.button_Changedpass.Click += new System.EventHandler(this.button_Changedpass_Click);
            // 
            // AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 384);
            this.Controls.Add(this.button_Changedpass);
            this.Controls.Add(this.textBox_newPassAgain);
            this.Controls.Add(this.textBox_newPass);
            this.Controls.Add(this.textBox_OldPass);
            this.Controls.Add(this.textBox_NameUser);
            this.Controls.Add(this.textBox_DisplayName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AccountInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_DisplayName;
        private System.Windows.Forms.TextBox textBox_NameUser;
        private System.Windows.Forms.TextBox textBox_OldPass;
        private System.Windows.Forms.TextBox textBox_newPass;
        private System.Windows.Forms.TextBox textBox_newPassAgain;
        private System.Windows.Forms.Button button_Changedpass;
    }
}