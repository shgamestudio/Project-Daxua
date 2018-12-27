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
    public partial class Menu : Form
    {
        
        
        private SoundPlayer _soundPlayer4;
        private SoundPlayer _soundPlayer5;
        
        /// test sound
        /// IWMPPlaylist
      
        /// 


        public Menu()
        {
            InitializeComponent();
            //_soundPlayer2 = new SoundPlayer("popkda.wav");
            //_soundPlayer3 = new SoundPlayer("popkda.wav");
            _soundPlayer4 = new SoundPlayer("btn_sound.wav");
            _soundPlayer5 = new SoundPlayer("btn_clicksoundhigh.wav");
            //
           // var player23 = new WMPLib.WindowsMediaPlayer();
           // var player24 = new WMPLib.WindowsMediaPlayer();
          //  player23.URL = "Resources\\popkda.wav";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            new Begin().Show();
            this.Hide();
        }

        // Đổi màu nút play + âm thanh
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            _soundPlayer4.Play();
             this.button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.play2));
            ///


        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.play1));


        }

        //Đổi màu nút exit + âm thanh
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            _soundPlayer4.Play();
            this.button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exit2));
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exit1));
        }

        //Đổi màu nút About + âm thanh
        private void button3_MouseEnter(object sender, EventArgs e)
        {

            _soundPlayer4.Play();
            this.button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about_small_editfont2));
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about_small_editfont));
        }





        private void Menu_Load(object sender, EventArgs e)
        {
            
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;

            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            

            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.URL = "Resources\\popkda_mp3.mp3";


            //load am thanh
            //_soundPlayer3.Play();
            //timer1.Start();

            //test





        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //_soundPlayer2.Play();
        }

        private void button1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            this.button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.play4));
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            this.button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exit3));
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            this.button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about_small_editfont3));
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            this.button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about_small_editfont));
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            this.button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.play1));
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            this.button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exit1));
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            _soundPlayer5.Play();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            _soundPlayer5.Play();
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            _soundPlayer5.Play();
        }
    }
}
