using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int carspeed=1;
        int x;
        Random r = new Random();



        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(carspeed);
            Barrier(carspeed);
            gameover();
            coincollect();
        }
        int coin = 0;



        void coincollect()
        {
            if(pictureBox_coin.Top< 641)
            pictureBox_coin.Top += carspeed;

            else
            {

                x = r.Next(0, 400);

                pictureBox_coin.Location = new Point(x, 0);

            }
                




            if (pictureBox_coin2.Top < 641)
                pictureBox_coin2.Top += carspeed;

            else
            {

                x = r.Next(0, 400);

                pictureBox_coin2.Location = new Point(x, 0);

            }



            if (pictureBox_car.Bounds.IntersectsWith(pictureBox_coin.Bounds))
            {
                coin++;
                label_coin.Text = "coins" + coin.ToString();
                x = r.Next(0, 500);
                pictureBox_coin.Location = new Point(x, 0);

            }

            if (pictureBox_car.Bounds.IntersectsWith(pictureBox_coin2.Bounds))
            {
                coin++;
                label_coin.Text = "coins" + coin.ToString();
                x = r.Next(0, 500);
                pictureBox_coin2.Location = new Point(x, 0);

            }



        }



        void gameover()
        {
            if(pictureBox_car.Bounds.IntersectsWith(pictureBox_barrier.Bounds))
            {
                timer1.Enabled = false;
                label_gameover.Visible = true;
            }



            if (pictureBox_car.Bounds.IntersectsWith(pictureBox_barrier2.Bounds))
            {
                timer1.Enabled = false;
                label_gameover.Visible = true;
            }


        }



       
       




        void Barrier(int speed)
        {


            if (pictureBox_barrier.Top >= 641)
            {
                x = r.Next(0, 200);

                pictureBox_barrier.Location =new Point(x, 0);


            }


            else
                pictureBox_barrier.Top += speed;


            if (pictureBox_barrier2.Top >= 641)
            {
                x = r.Next(200, 500);

                pictureBox_barrier2.Location = new Point(x, 0);


            }


            else
                pictureBox_barrier2.Top += speed;

        }



        void moveline(int speed)
        {
            if (pictureBox1.Top >= 641)
                pictureBox1.Top = 0;
            else
            pictureBox1.Top += speed;




            if (pictureBox2.Top >= 641)
                pictureBox2.Top = 0;
            else
                pictureBox2.Top += speed;



            if (pictureBox3.Top >= 641)
                pictureBox3.Top = 0;
            else
                pictureBox3.Top += speed;



            if (pictureBox4.Top >= 641)
                pictureBox4.Top = 0;
            else
                pictureBox4.Top += speed;



        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_barrier_Click(object sender, EventArgs e)
        {

        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if(pictureBox_car.Left>0)
                pictureBox_car.Left += -11;


            }

            if (e.KeyCode == Keys.Right)
            {
                if(pictureBox_car.Left<500-pictureBox_car.Width*2)
                pictureBox_car.Left += 11;


            }

            if(e.KeyCode==Keys.Up)
            {
                if (carspeed < 15)
                    carspeed++;


            }

            if(e.KeyCode==Keys.Down)
            {
                if(carspeed>0)
                carspeed--;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }



}
