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
using System.Drawing.Imaging;


namespace fade
{
    public partial class Begin : Form
    {
        private SoundPlayer _soundPlayer1; //Biến âm thanh
        private SoundPlayer _soundPlayer2; //zed cuoi
        private SoundPlayer _soundPlayer3;

        public Begin()
        {
            InitializeComponent();
            _soundPlayer1 = new SoundPlayer("btn_sound.wav");
            _soundPlayer2 = new SoundPlayer("zed_laugh.wav");
            _soundPlayer3 = new SoundPlayer("btn_next2.wav");
        }

        int opacity = 0; //độ trong hàm mờ ảnh
        float opa = 1F;
        int playone=0;

        int delay = 0;
        int stop_count=0; //Delay để gamer đọc 
        int skip_btn = 0; //Nút skip
        int cong_tac = 0;
       
        int cau = 1;   // Thứ tự câu thoại auto =1
        int counter = 0; //thứ tự con trỏ thoại
        int len = 0; //độ dài max câu thoại

       
       
        string txt1 = "Daxua:  Zed! Ngươi đã bại trận trước lưỡi kiếm của ta. Nhưng trong lúc giao đấu ta thấy ngươi có sử dụng một chiêu                      thức rất giống với 'Phong Tuyệt Kỹ' - Thứ mà năm xưa kẻ sát hại Trưởng Lão Souma đã sử dụng.\r\n                 Hãy khai mau! Có phải ngươi chính là kẻ đã hạ sát vị Sư Phụ đáng kính của ta? Hãy trả lời ta đi Zed!!\r\n";
        string txt2 = "Zed:        ................................................................. MUAHA HA HA HA HA..........A.......A..........A.......A.........A!!!         ";
        string txt3 = "Ionia 20 năm trước... Người ta truyền miệng nhau rằng.............";
        string txt4 = "Có một cậu bé mồ côi tên là Daxua sống lang thang ở núi thiên phận Navori, tuy mới 8 tuổi nhưng cậu đã biết sử dụng kiếm một cách thuần thục. Mặc dù có khả năng thiên bẩm về kiếm thuật nhưng với lối sống cô độc và bản tính kiêu ngạo của mình, không ai muốn kết thân với cậu.\r\n";
        string txt5 = "Tất cả mọi người đều xa lánh Daxua, ngoại trừ một người...đó là vị Trưởng Lão Souma - Người nắm giữ Phong Tuyệt Kỹ tối thượng. Ông nhìn thấy tiềm năng ở Daxua và nhận cậu làm đồ đệ của mình.";
        string txt6 = "Quả thật là Trưởng Lão Souma đã không nhìn lầm người, Daxua sau mấy năm theo ông đã như diều gặp gió ngày càng tiến bộ. Cậu hăng hái tập luyện và không ngừng nâng cao kiếm thuật của mình.\r\nĐến một ngày thì cuối cùng cậu đã luyện thành công Phong Tuyệt Kỹ -  kiếm thuật tâm đắc nhất mà sư phụ Souma muốn truyền lại cho cậu.";
        string txt7 = "Do là người duy nhất ở Ionia luyện thành công được Phong Tuyệt Kỹ sau Trưởng Lão Souma nên Daxua được mọi người phong cho chức cận vệ riêng của Trưởng Lão.\r\nTừ đó, Daxua theo chân Trưởng Lão như hình với bóng, đi theo và bảo vệ ông xuyên suốt, cũng chính nhờ vậy mà Daxua gặp được rất nhiều người và dần dần sống hòa đồng với mọi người hơn, cuộc sống của cậu cũng không còn chỉ một màu xám như trước.";
        string txt8 = "Tuy nhiên khoảng thời gian thanh bình của Daxua ở Ionia không kéo dài được lâu, lúc bấy giờ cũng là thời kỳ hưng thịnh nhất của Đế Chế Noxus do Darius đứng đầu. Noxus liên tục xâm chiếm các vùng đất khác từ Valoran, Bilgewater, Zaun và tất nhiên Ionia là một trong những lãnh địa tiếp theo mà Noxus nhắm đến!";
        string txt9 = "Cuối cùng không ngoài dự đoán, chiến tranh giữa Ionia và Noxus đã bùng nổ.\r\n";
        string txt10 = "Lúc này Daxua không thể kìm hãm ham muốn ra chiến trường giết địch lập công nên đã quên đi nhiệm vụ bảo vệ Trưởng Lão, với niềm tin ngu ngốc sẽ thay đổi cục diện trận đấu bằng lưỡi kiếm của mình Daxua một mình một thân tả xung hữu đột lao ra chiến trường.";
        string txt11 = "Mãi mê rượt đuổi chém giết kẻ thù đến một lúc, Daxua chợt nhận ra tóc và áo mình đã dính đầy máu và dường như đã quên đi nhiệm vụ mà mọi người bắt mình phải khắc cốt ghi tâm, đó là dù có chết cũng phải bảo vệ Trưởng Lão Souma. Thế là cơn háu chiến của Daxua nguôi dần, thay vào đó là cảm giác lo lắng về sự an toàn của trưởng lão, lập tức Daxua phóng trở về như một cơn gió. Nhưng đến nơi thì đã.....";
        
        string txt13 = "..... quá muộn, sự bồng bột tự cao của tuổi trẻ đã phải trả một cái giá quá đắt. Trong lúc Daxua vắng mặt, Trưởng Lão Souma đã bị ám sát. Mặc cho Daxua thét lên trong đau đớn và hối hận nhưng vẫn còn một điều tồi tệ hơn chờ đợi Daxua.";
        string txt14 = "Đó chính là Trưởng Lão đã bị giết bởi Phong Tuyệt Kỹ, chiêu thức mà chỉ độc nhất Trưởng Lão Souma và.....Daxua biết, lúc này tất cả các ánh mắt đều dồn về Daxua. Cậu chính là đối tượng đáng nghi nhất, thậm chí chi tiết Daxua vắng mặt trong lúc trưởng lão bị giết còn làm tăng thêm sự nghi ngờ của mọi người. Cuối cùng xứ Ionia đã kết tội Daxua chính là kẻ đã ám sát Trưởng Lão Souma!";
        string txt15 = "Không thể chấp nhận được sự thật đau đớn này cộng thêm sự dằn vặt bản thân. Để đi tìm hung thủ thật sự kẻ đã hạ sát sư phụ mình Daxua không còn cách nào khác ngoài tẩu thoát khỏi xứ Ionia dù biết thế lại càng thêm khẳng định tội danh của mình. Daxua lang thang đi qua những ngọn núi tới bất kỳ đâu có manh mối, lúc nào cũng chìm trong cơn say cho quên nỗi đau và mất mát..... như một thanh kiếm không còn vỏ.......";
        string txt16 = "Zed: ...Đừng vội đắc thắng hỡi tên kiếm sĩ hạ đẳng kia, hãy mở to mắt nhìn xem từ nãy giờ ngươi chỉ toàn đánh vào bóng của ta mà thôi. Còn câu hỏi của ngươi thì nếu ngươi thu thập đủ 5 viên đá Kinkoustone ở Shurima, Freljord, Targon, Void và Ionia rồi đưa chúng cho ta thì ta sẽ cho ngươi câu trả lời.....! Còn bây giờ ta không có thời gian chơi đùa với ngươi, khi nào ngươi thu thập đủ những viên đá chúng ta sẽ gặp lại!";
        string txt17 = "Ta không chắc sẽ đưa cho ngươi được thứ mà ngươi muốn..... nhưng ĐƯỢC ta sẽ tìm 5 viên đá đó, còn ngươi thì hãy ráng mà giữ lời hứa của mình Zed không thì lần sau gặp lại ta sẽ chém cả bóng lẫn người!";

        private void Begin_Load(object sender, EventArgs e)
        {
            this.Controls.SetChildIndex(this.button3, 0);
            //
            
            //--------------
            

            //
            //Image vidu = Image.FromFile("Resources\\ys_vs_zed.jpg");
            


            pictureNoxus.Visible = false;
            pictureNoxus.Enabled = false;
            pictureIre.Visible = false;
            pictureIre.Enabled = false;
            //txt = label1.Text;

            axWindowsMediaPlayer2.URL = "Resources\\ys_kill_zed.wav";

            //load Nhạc nền
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.URL = "Resources\\after_fight.wav";
            
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;

            len = txt1.Length;
            label1.Text = "";
            timerTalk.Start();
        }

        public Image SetImageOpacity(Image image, float opacity)
        {
            try
            {
                //create a Bitmap the size of the image provided  
                Bitmap bmp = new Bitmap(image.Width, image.Height);

                //create a graphics object from the image  
                using (Graphics gfx = Graphics.FromImage(bmp))
                {

                    //create a color matrix object  
                    ColorMatrix matrix = new ColorMatrix();

                    //set the opacity  
                    matrix.Matrix33 = opacity;

                    //create image attributes  
                    ImageAttributes attributes = new ImageAttributes();

                    //set the color(opacity) of the image  
                    attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                    //now draw the image  
                    gfx.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                }
                return bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            skip_btn = 1;
            _soundPlayer3.Play();
            
        }







        //Timer load đối thoại
        private void timerTalk_Tick(object sender, EventArgs e)
        {
            if(cau==1) //Thoại đầu của Daxua
            {
                counter++;
                if(counter>len)
                {
                    cau = 2;
                    len = len + txt2.Length;
                    txt2 = txt1 + txt2;
                }
                else
                {
                    label1.Text = txt1.Substring(0, counter);
                }
            }
           
            if(cau==2) //Thoại Zed cười trả lời
            {
                if (cong_tac == 0)
                {
                    stop_count++;
                    
                }
                if(stop_count==50)
                {
                    pictureBox1.Image = Properties.Resources.zed_mat;//Load avatar Zed
                    cong_tac = 1;
                    counter++;
                    if (counter == len - 77 )
                    { _soundPlayer2.Play(); }//Load tiếng zed cười
                    if (counter > len)
                    {                   
                        button3.Visible = true;
                        if(skip_btn==1)
                        {
                            cau = 3;
                            stop_count = 0;
                            label1.Text = "";
                            counter = 0;
                            len = txt3.Length;
                            skip_btn = 0;
                            axWindowsMediaPlayer1.settings.setMode("loop", true);
                            axWindowsMediaPlayer1.URL = "Resources\\20_edit2.mp3"; // đổi sang nhạc quá khứ
                            button3.Visible = false;
                            cong_tac = 0;
                        }
                    }              
                    else
                    {
                        label1.Text = txt2.Substring(0, counter);
                    }
                }
                
                
            }

            if(cau==3)
            {
                
                if (delay<60)
                {
                    pictureBox1.Visible = false;
                    label1.Visible = false;
                    pictureHinh.Dock = DockStyle.Fill;
                    pictureHinh.Image = Properties.Resources._20nam;
                    delay++;
                    if(delay==60)
                    {
                        
                        timerTalk2.Start();
                        timerTalk.Stop();
                    }
                }
                if(delay==61)
                {
                    pictureHinh.Dock = DockStyle.None;
                    pictureBox1.Visible = true;
                    label1.Visible = true;

                    pictureBox1.Image = Properties.Resources.ionia_icon;
                    pictureHinh.Image = Properties.Resources.inonia_noneword;
                    

                    if(stop_count==0)
                    {
                        counter++;
                    }
                    if(counter>len)
                    {
                        button3.Visible = true;
                        if (skip_btn == 1)
                        {
                            delay = 0; //reset delay
                            opacity = 0;//reset opacity
                            cau = 4;
                            label1.Text = "";
                            counter = 0;
                            len = txt4.Length;
                            skip_btn = 0;
                            button3.Visible = false;
                            pictureHinh.Image = Properties.Resources.yasuo_young;
                        }

                    }
                    else
                    {
                        label1.Text = txt3.Substring(0, counter);
                    }
                }

            }

            if(cau==4)
            {
                
                counter++;
                if(counter>len)
                {
                    button3.Visible = true;
                    if(skip_btn==1)
                    {
                        cau = 5;
                        len = len + txt5.Length;
                        txt5 = txt4 + txt5;
                        counter = txt4.Length;
                        skip_btn = 0;
                        button3.Visible = false;
                        pictureHinh.Image = Properties.Resources.souma_hand;

                    }


                }
                else
                {
                    label1.Text = txt4.Substring(0, counter);
                }

            }
            if(cau==5)
            {
                
                counter++;
                if(counter>len)
                {
                    button3.Visible = true;
                    if(skip_btn==1)
                    {
                        cau = 6;
                        counter = 0;
                        len = txt6.Length;
                        skip_btn = 0;
                        button3.Visible = false;
                        pictureHinh.Image = Properties.Resources.yasuo_art;
                    }
                }
                else
                {
                    label1.Text = txt5.Substring(0, counter);
                }

            }

            if(cau==6)
            {
                
                counter++;
                if (counter > len)
                {
                    button3.Visible = true;
                    if (skip_btn == 1)
                    {
                        cau = 7;
                        label1.Text = "";
                        counter = 0;
                        len = txt7.Length;
                        button3.Visible = false;
                        skip_btn = 0;
                        pictureHinh.Image = Properties.Resources.ys_flute;
                    }

                }
                else
                {
                    label1.Text = txt6.Substring(0, counter);
                }
            }

            if(cau==7)
            {
                //pictureHinh.Image = Properties.Resources.ys_flute;              
                counter++;
                if (counter > len)
                {
                    button3.Visible = true;
                    if (skip_btn == 1)
                    {
                        cau = 8;
                        label1.Text = "";
                        counter = 0;
                        len = txt8.Length;
                        button3.Visible = false;
                        skip_btn = 0;
                        axWindowsMediaPlayer1.settings.setMode("loop", true);
                        axWindowsMediaPlayer1.URL = "Resources\\god_king_sound.mp3";
                    }

                }
                else
                {
                    label1.Text = txt7.Substring(0, counter);
                }
            }

            if (cau == 8)
            {
                pictureNoxus.Visible = true;
                pictureNoxus.Enabled = true;

                //pictureHinh.Image = Properties.Resources.ys_flute;
                pictureBox1.Image = Properties.Resources.noxus_icon;
                this.pictureNoxus.Size = new System.Drawing.Size(1193, 613);

                counter++;
                if (counter > len)
                {
                   
                    button3.Visible = true;

                    if (skip_btn == 1)
                    {
                        cau = 9;
                        label1.Text = "";
                        counter = 0;
                        len = txt9.Length;
                        button3.Visible = false;
                        skip_btn = 0;
                    }

                }
                else
                {
                    label1.Text = txt8.Substring(0, counter);
                }
            }

            if (cau == 9)
            {

               
                pictureNoxus.Visible = false;
                pictureNoxus.Enabled = false;

                pictureIre.Visible = true;
                pictureIre.Enabled = true;



                this.pictureIre.Size = new System.Drawing.Size(1193, 613);




                counter++;
                if (counter > len)
                {
                   
                    button3.Visible = true;
                    
                    if (skip_btn == 1)
                    {//uuuuuuuuuuuuuuuuuuuuuuuuuuuuuu
                        cau = 10;
                        counter = txt9.Length;
                        len = txt9.Length + txt10.Length;
                        button3.Visible = false;
                        skip_btn = 0;
                        stop_count = 0;
                        txt10 = txt9 + txt10;
                        pictureBox1.Image = Properties.Resources.ionia_icon;
                        pictureHinh.Image = Properties.Resources.yasuo_transparent_black;
                        
                    }

                }
                else
                {
                    label1.Text = txt9.Substring(0, counter);
                }
            }

            if (cau == 10)
            {

                pictureIre.Visible = false;
                pictureIre.Enabled = false;
                
                counter++;
                if (counter > len)
                {
                   
                    button3.Visible = true;


                    if (skip_btn == 1)
                    {

                       
                        axWindowsMediaPlayer_YS.Visible = true;
                        axWindowsMediaPlayer_YS.URL = "Resources\\ys_fight.mp4";
                        ///
                        cau = 11;
                        counter = txt10.Length;
                        len = txt11.Length;
                        button3.Visible = false;
                        skip_btn = 0;
                        //txt11 = txt10 + txt11;

                        //
                        pictureHinh.Visible = false; // ẩn hình daxua xông lên
                        //
                        axWindowsMediaPlayer1.settings.setMode("loop", true);
                        axWindowsMediaPlayer1.URL = "Resources\\ys_fight_sound.mp3";
                    }

                }
                else
                {
                    label1.Text = txt10.Substring(0, counter);
                }

            }

            if (cau == 11)
            {
                if (cong_tac == 0)
                { stop_count++; }

                if (stop_count == 530)
                {
                    label1.Text = "";
                    counter = 0; //chỉnh
                    axWindowsMediaPlayer_YS.Visible = false;
                    //axWindowsMediaPlayer1.settings.setMode("loop", true);
                    //axWindowsMediaPlayer1.URL = "Resources\\ys_drama_sound.mp3";
                    cong_tac = 1;
                    stop_count = -1;

                }
                
                if(stop_count==-1)
                {
                    counter++;
                    if (counter == len - 35)
                    {
                        pictureYS_run.Enabled = true;
                        pictureYS_run.Visible = true;
                    }
                    if(counter>len)
                    {
                        axWindowsMediaPlayer_YS.Visible = false;
                        
                        //
                        
                        //

                        button3.Visible = true;
                        
                        if (skip_btn == 1)
                        {
                            pictureYS_run.Enabled = false;
                            pictureYS_run.Visible = false;
                            pictureHinh.Visible = true;
                            button3.Visible = false;
                            pictureHinh.Image = Properties.Resources.dead;
                            cau = 12;
                            len = txt13.Length;
                            counter =0;
                            label1.Text = "";
                            skip_btn = 0;

                        }

                    }
                    else
                    {
                        label1.Text = txt11.Substring(0,counter);
                    }
                }
                

            }

            if(cau==12)
            {
                counter++;
                if(counter>len)
                {
                   
                    button3.Visible = true;
                    if(skip_btn==1)
                    {
                        button3.Visible = false;
                        cau = 13;
                        len = txt14.Length;
                        counter = 0;
                        label1.Text = "";
                        skip_btn = 0;
                       
                    }
                }
                else
                {
                    label1.Text = txt13.Substring(0, counter);
                }
                
            }

            if (cau == 13)
            {
                counter++;
                if (counter > len)
                {

                    button3.Visible = true;
                    if (skip_btn == 1)
                    {
                        skip_btn = 0;
                        button3.Visible = false;
                        label1.Text = "";
                        cau = 14;
                        counter = 0;
                        len = txt15.Length;
                        pictureHinh.Image = Properties.Resources.ys_run;

                    }
                }
                else
                {
                    label1.Text = txt14.Substring(0, counter);
                }
            }

            if (cau == 14)
            {
                counter++;
                if (counter > len)
                {
                    button3.Visible = true;
                    if (skip_btn == 1)
                    {
                        skip_btn = 0;
                        button3.Visible = false;
                        counter = 0;
                        label1.Text = "";
                        len = txt16.Length;
                        cau = 15;
                       


                    }
                }
                else
                {
                    label1.Text = txt15.Substring(0, counter);
                }
            }

            if (cau==15)
            {

                if (delay < 60)
                {
                    //pictureBox1.Visible = false;
                    //label1.Visible = false;
                    //pictureHinh.Dock = DockStyle.Fill;
                    //pictureHinh.Image = Properties.Resources._20nam;
                    delay++;
                    if (delay == 60)
                    {

                        timerTalk2.Start();
                        timerTalk.Stop();

                       
                    }
                }
                
                if(delay==61)
                {
                    if (playone == 1)
                    {
                        axWindowsMediaPlayer1.settings.setMode("loop", true);
                        axWindowsMediaPlayer1.URL = "Resources\\after_fight.wav";
                        pictureHinh2.Enabled = true;
                        pictureHinh2.Visible = true;
                        pictureHinh.Image = Properties.Resources.ys_vs_zed_edit; //
                        pictureHinh2.Image = Properties.Resources.ys_vs_zed;
                        pictureBox1.Image = Properties.Resources.zed_mat;//Load avatar Zed
                        playone = 0;
                    }
                    counter++;
                    if (counter > len)
                    {
                        pictureHinh2.Controls.Add(button3);
                        button3.Location = new Point(1000, 550);
                        button3.BackColor = Color.Transparent;
                        button3.Visible = true;
                        if (skip_btn == 1)
                        {
                            skip_btn = 0;
                            button3.Visible = false;
                            counter = 0;
                            label1.Text = "";
                            len = txt17.Length;
                            cau = 16;
                            opacity = 0;
                            //
                            pictureHinh.Controls.Add(pictureHinh2);
                            pictureHinh2.Location = new Point(0, 0);
                            pictureHinh2.BackColor = Color.Transparent;
                            //

                        }
                    }
                    else
                    {
                        label1.Text = txt16.Substring(0, counter);
                    }


                    
                }


            }

            if(cau==16)
            {

                pictureHinh2.Image = SetImageOpacity(pictureHinh2.Image, opa);

                if (opa > 0)
                {
                    opa -= 0.015F;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.ys_ava;
                    counter++;

                    if (counter > len)
                    {
                        button3.Visible = true;
                        if (skip_btn == 1)
                        {
                            skip_btn = 0;
                            button3.Visible = false;
                            counter = 0;
                            label1.Text = "";
                            len = txt16.Length;
                            cau = 17;


                        }
                    }
                    else
                    {
                        label1.Text = txt17.Substring(0, counter);
                    }
                    
                }

            }


            if (cau==17)
            {
               // Chuyển form
                
            }

        }


        


        // Timer fade hình
        private void timerTalk2_Tick(object sender, EventArgs e)
        {

            if (opacity < 45)
            {
                Image img = pictureHinh.Image;
                using (Graphics g = Graphics.FromImage(img))
                {
                    Pen pen = new Pen(Color.FromArgb(opacity, 0, 0, 0), img.Width);
                    g.DrawLine(pen, -1, -1, img.Width, img.Height);
                   // g.DrawLine(pen, img.Width, img.Height, img.Width, img.Height);
                    g.Save();  
                }
                pictureHinh.Image = img;
                opacity++;
            }
            else
            {
                delay = 61;
                timerTalk.Start();
                timerTalk2.Stop();
                playone = 1;
            }

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            _soundPlayer1.Play();
            this.button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tiep2));
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tiep));
        }
    }
}
