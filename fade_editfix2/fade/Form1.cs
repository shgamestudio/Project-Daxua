using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace fade
{
    public partial class Form1 : Form
    {
        int play = 0;
        private SoundPlayer _soundPlayer1; //Biến âm thanh


        public Form1()
        {

            InitializeComponent();
            _soundPlayer1 = new SoundPlayer("SHvoice.wav");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.5)
                this.Opacity -= 0.015;
            
            else
            {
                
                timer1.Stop();

                //using (Form2 fm = new Form2())
                //{

                //    fm.ShowDialog();

                //}
                new Form2().Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _soundPlayer1.Play();
            pictureBox1.Image = Properties.Resources.SHG_right;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            // auto next scence
           
                timer2.Start();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (play<5)
                play++;
            else
            {
                timer2.Stop();
                timer1.Start();
            }
        }
    }
}
