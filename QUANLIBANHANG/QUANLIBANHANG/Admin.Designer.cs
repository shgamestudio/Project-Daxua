namespace QUANLIBANHANG
{
    partial class Admin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_DoanhThu = new System.Windows.Forms.TabPage();
            this.tabPage_Food = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_DoanhThu);
            this.tabControl1.Controls.Add(this.tabPage_Food);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_DoanhThu
            // 
            this.tabPage_DoanhThu.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DoanhThu.Name = "tabPage_DoanhThu";
            this.tabPage_DoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DoanhThu.Size = new System.Drawing.Size(792, 424);
            this.tabPage_DoanhThu.TabIndex = 1;
            this.tabPage_DoanhThu.Text = "Doanh Thu";
            this.tabPage_DoanhThu.UseVisualStyleBackColor = true;
            // 
            // tabPage_Food
            // 
            this.tabPage_Food.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Food.Name = "tabPage_Food";
            this.tabPage_Food.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Food.Size = new System.Drawing.Size(792, 424);
            this.tabPage_Food.TabIndex = 2;
            this.tabPage_Food.Text = "Thức Ăn";
            this.tabPage_Food.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_DoanhThu;
        private System.Windows.Forms.TabPage tabPage_Food;
    }
}