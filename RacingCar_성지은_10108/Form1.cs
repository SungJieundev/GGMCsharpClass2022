using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingCar_성지은_10108
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int carSpeed = 0;

        void MoveLine(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveLine(5);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (pictureBox_Car.Left > 0)
                    pictureBox_Car.Left += -5;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (pictureBox_Car.Right < 400 - pictureBox_Car.Width / 2)
                    pictureBox_Car.Left += 5;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (carSpeed < 15)
                {
                    carSpeed++;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (carSpeed > 0)
                {
                    carSpeed--;
                }
            }
        }
    }
}
