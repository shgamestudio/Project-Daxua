using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;    //Thư viện âm thanh
using System.Threading;

namespace Tudau
{
    public partial class Form1 : Form
    {
        //Định nghĩa Controller
        enum Position
        {
            Left, Right, Up, Down, Stop, Attack_Q, Stop_Q
        }

        //Khai báo biến
        private int isHuong;
        private int _x;     //tọa độ ngang
        private int _y;     //tọa độ dọc
        private int check=-1;   //Để qua trái ko bị ảnh hưởng phải
        private int check2 = -1;   //Để qua phải không bị ánh hưởng trái
        private int check3 = -1;    //Để lên không bị ánh hưởng xuống
        private int check4 = -1;//Để xuống không bị ánh hưởng lên
        private int checkQ = -1; //Để ko trùng Q
        private int tanghang; //Ma trận hàng      
        private int tangcot;  //Ma trận cột
        private int Q_Return;
        
     
        /// hình ảnh Q
        private int trigger;
        private int isLeft;
        //

        private Bitmap _h; //ảnh ys
        private Bitmap _l; // ảnh lốc Q
        private Bitmap _m;
        private int _f ;
        private int _xLoc;
        private int _yLoc;
        private Position _objPosition; //Biến vị trí
        private int isPhai,isTrai,isXuong,isLen;
        // Âm thanh Q
        private int Q_count;
        private SoundPlayer _soundPlayer1; //Biến âm thanh
        private SoundPlayer _soundPlayer2; //Biến âm thanh
        private SoundPlayer _soundPlayer3; //Biến âm thanh

        public Form1()
        {
            InitializeComponent();
            isHuong = 1;
            isPhai =0;
            isTrai = 0;
            isXuong = isLen = 0;


            _x = 100;
            _y = 100;
            _h = new Bitmap("ys4line_edittest7-ATTFrame_1_TRANS18.png"); // gán hình chính của Ys
            _l = new Bitmap("Loc_Q_750_200.png"); //gán hình ảnh của Lốc Q
            
            _objPosition = Position.Stop; //Set vị trí mặc định là đứng yên


            ///DIeu khien Lốc
            _xLoc = 50;
            _yLoc = 50;
            _f = 0;
            Q_Return = 0;

            ////
            tanghang = 1;
            tangcot = 0;
            isLeft = 0;
      
            /// test
         
          
            trigger = 0;

            /// test

            // Gán âm thanh cho biến âm thanh
            Q_count = 1;

            _soundPlayer1 = new SoundPlayer("yasuoQ1.wav");
            _soundPlayer2 = new SoundPlayer("yasuoQ2.wav");
            _soundPlayer3 = new SoundPlayer("yasuoQ3.wav");


        }

        //Hàm vẽ Render Animation
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if(Q_count==4 && Q_Return==0) 
            {
                if (isHuong == 1)
                {
                    e.Graphics.DrawImage(_l, _x + _xLoc, _y - 46,
                     new Rectangle(_f * 125, 0, 125, 200), GraphicsUnit.Pixel);
                }

                if (isHuong == 2) // Lốc chạy sag trái
                {
                    e.Graphics.DrawImage(_l, _x - _xLoc, _y - 46,
                  new Rectangle(_f * 125, 0, 125, 200), GraphicsUnit.Pixel);
                }
                if (isHuong == 3)//Lốc chạy xuống
                {
                    e.Graphics.DrawImage(_l, _x + 15, _y + _yLoc,
                  new Rectangle(_f * 125, 0, 125, 200), GraphicsUnit.Pixel); Console.WriteLine(Q_count);
                }
                if (isHuong == 4)//Lốc chạy lên
                {
                    e.Graphics.DrawImage(_l, _x + 15, _y - _yLoc,
                  new Rectangle(_f * 125, 0, 125, 200), GraphicsUnit.Pixel); Console.WriteLine(Q_count);
                }
            }

            if (trigger == 1) //Left_Q  #################
            {
                e.Graphics.DrawImage(_h, _x + 70, _y,
               new Rectangle(845, tangcot * 140, -236, 138), GraphicsUnit.Pixel);   // 324=108*3
            }
            else if (trigger == 2) //Right_Q ###############
            {
                
                e.Graphics.DrawImage(_h, _x, _y,
               new Rectangle(756, tangcot * 140, 236, 138), GraphicsUnit.Pixel);   // 324=108*3
               
            }
            else if(trigger==3) // Down_Q #################
            {
               
                e.Graphics.DrawImage(_h, _x-15, _y-5,
                new Rectangle(845, tangcot * 140, 150, 300), GraphicsUnit.Pixel);

            }
            else if(trigger==4) // Up_Q ####################
            {
               
                e.Graphics.DrawImage(_h, _x - 15, _y - 140,
                new Rectangle(1030, (tangcot - 1) * 140, 210, 290), GraphicsUnit.Pixel);       //Rectangle(1030, (tangcot-1) * 140, 210, 290), GraphicsUnit.Pixel);
               

            }


            else // Vẽ di chuyển 
            {
                    
                     e.Graphics.DrawImage(_h, _x, _y,
                     new Rectangle(tanghang * 110, tangcot * 140, 108 , 138), GraphicsUnit.Pixel);     //36*3, 46*3        


            }
        }


        //Đồng hồ lặp hình ảnh
        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            if (_objPosition == Position.Right || (check2==0 && check ==1 && check3 != 0 && check4 != 0))     //Sang phải
            {
                isHuong = 1; //// DInh vi phai 
                //isPhai = 1;  //isPhai2 = 1; isTrai2 = 0;


                isLeft = 0;
                tanghang++;
                tangcot = 0;
                _x += 15;
                trigger = 0;
               
                if (tanghang > 4)
                { tanghang = 1; }
                ///int milliseconds = 2000;
                ///Thread.Sleep(milliseconds);

            }

            //System.Console.WriteLine(check);
            if (_objPosition == Position.Left || (check == 0 && check2 ==1 && check3!=0&&check4!=0))      //Sang trái
            {
                isHuong = 2; ///// DInh vi trai 
                isTrai = 1; //isTrai2 = 1; isPhai2 = 0;

                isLeft = 1;
                tanghang++;
                tangcot = 1;
                _x -= 15;
                trigger = 0;

                if (tanghang > 4)
                { tanghang = 1; }
            }

            if (_objPosition == Position.Down || (check4== 0 && check2 == 1 && check != 0 && check3 != 0))      //Xuống
            {
                isHuong = 3; //////  Dinh vi xuong
                isLeft = 2;
                tanghang++;
                tangcot=2;
                _y += 15;
                trigger = 0;

                if (tanghang > 4)
                { tanghang = 1; }
            }

            if (_objPosition == Position.Up || (check3 == 0 && check2 == 1 && check != 0 && check4 != 0))        //Lên
            {
                isHuong = 4;///////   DInh vi len
                isLeft = 3;
                tanghang++;
                tangcot = 3;
                _y -= 15;
                trigger = 0;

                if (tanghang > 4)
                { tanghang = 1; }

            }

            if (_objPosition == Position.Attack_Q || (checkQ==0 && check3 != 0 && check2 == 1 && check != 0 && check4 != 0))   //  Q Attack            eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee
            {
                if (isLeft == 1)
                { trigger = 1; }

                if (isLeft==0)
                { trigger = 2; }

                if(isLeft==2)
                { trigger = 3; }

                if(isLeft==3)
                { trigger = 4; }
            }


            if (_objPosition == Position.Stop_Q)        //Dừng Q attack
            {
                trigger = 0;
            }


            if (_objPosition==Position.Stop)        //Dừng di chuyển
            {
               
            }
            
            Invalidate(); 
        }


        //Gán các Key_Down Button cho Controller điều khiển Animation
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                
                check3 = 0;
                _objPosition = Position.Up;

            }

            if (e.KeyCode == Keys.Down)
            {
                check4 = 0;
                _objPosition = Position.Down;
            }

            if (e.KeyCode == Keys.Left)
            {            
                
                _objPosition = Position.Left;
                check = 0;
                checkQ = 1;

            }

            if (e.KeyCode == Keys.Right)
            {
                _objPosition = Position.Right;
                check2 = 0;
                

            }

            if (e.KeyCode == Keys.Q)
            {

                checkQ = 0;
                
                _objPosition = Position.Attack_Q;

                

                if (Q_count == 1)
                { _soundPlayer1.Play(); }

                if (Q_count == 2)
                { _soundPlayer2.Play();
                    _h = new Bitmap("Q2_ALL_EFF_trans.png");
                }
                if (Q_count == 3)
                {
                    _soundPlayer3.Play();
                    _h = new Bitmap("Q3_ALL_EFF_trans_fix.png");

                }

                if (Q_count == 4)
                {
                    
                    _h = new Bitmap("ys4line_edittest7-ATTFrame_1_TRANS18.png"); //Load hình chính
                    _soundPlayer1.Play();
                    
                }
                if(Q_count>4)
                {

                    _soundPlayer2.Play();
                    _h = new Bitmap("Q2_ALL_EFF_trans.png");
                    Q_count = 2;

                }

                Q_count++;

            }
           

        }

        //Dừng hoạt ảnh bằng Key_Up
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                check3 = 1;
                _objPosition = Position.Stop;
            }

            if (e.KeyCode == Keys.Down)
            {
                check4 = 1;
                _objPosition = Position.Stop;
            }

            if (e.KeyCode == Keys.Left)
            {
                _objPosition = Position.Stop;
                check = 1;
            }

            if (e.KeyCode == Keys.Right)
            {
                _objPosition = Position.Stop;
                check2 = 1;
            }

            if(e.KeyCode==Keys.Q)
            {
                checkQ = 1;


                _objPosition = Position.Stop_Q;
            }
         }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void timerQ_Tick(object sender, EventArgs e)
        {
            if (Q_count == 4 )
            {

                _xLoc += 25;
                _yLoc += 25;
                if (_xLoc > 375)
                {
                    _xLoc = 0;
                    Q_Return = 1;
                }
                if (_yLoc > 375)
                {
                    _yLoc = 0;
                    Q_Return = 1;
                }
                if (_f == 5)
                { _f = 0; }

                _f++;
            }
            if(Q_count>4)
            { Q_Return = 0; }
           
            Invalidate();
        }
    }
}
