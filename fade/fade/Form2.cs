using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace fade
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //textBox1.Text = @"D:\backup hình project daxua\ysvideo_uncen.mp4";

            //axWindowsMediaPlayer1.URL = "Resources\\ysvideo_2.mp4";

            //string filename = "ysvideo_2.mp4";
            //string path = System.IO.Path.GetFullPath(filename);

            //string url = new Uri(path).AbsoluteUri;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.25)
                this.Opacity -= 0.05;
            else
            {
                timer1.Stop();
                this.Hide();
                using (Menu fm = new Menu())
                {
                    fm.ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            timer1.Start();
        }
    }
}
