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
        int play = 0;
        int _stoptimer=0;
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
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 1;
            timer2.Start();
            //button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.5)
                this.Opacity -= 0.025;
            else
            {
                timer1.Stop();

                //using (Menu fmmenu = new Menu())
                //{
                //    fmmenu.ShowDialog();
                //}
                new Menu().Show();
                this.Hide();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _stoptimer = 1;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            timer1.Start();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (_stoptimer == 0)
            {
                if (play < 82)
                    play++;
                else
                {
                    timer2.Stop();
                    timer1.Start();
                }
            }
        }
    }
}
