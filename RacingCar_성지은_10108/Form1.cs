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

        void MoveLine(int speed) //pictureBox 가 화면에서 사라지면 다시 위로 끌어올림
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

        private void timer1_Tick(object sender, EventArgs e) //100분의 1초마다 Tick, event 발생 즉 100분의 1초마다 MoveLine() 호출
        {
            MoveLine(carSpeed);
            ExpensiveCar(carSpeed);
            GameOver();
            Coins(carSpeed);
            coinsCollection();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (pictureBox_Car.Left > 0) //벽뚫 방지
                    pictureBox_Car.Left += -10;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (pictureBox_Car.Right < 400 - pictureBox_Car.Width / 2)
                    pictureBox_Car.Left += 10;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (carSpeed < 15) //최대 속도 15
                {
                    carSpeed++; //MoveLine의 speed
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (carSpeed > 0) //최소 속도 0
                {
                    carSpeed--;
                }
            }
        }

        Random r = new Random();
        int x;

        void ExpensiveCar(int speed) //expensiveCar이 화면에서 사라지면 끌어올림 //= MoveLine()
        {
            if (pictureBox_expensiveCar.Top >= 500)
            {
                x = r.Next(0, 200); //pictureBox_expensiveCar 의 좌표가 겹치지 않도록 설정
                pictureBox_expensiveCar.Location = new Point(x, 0); //expensiveCar 의 위치를 (랜덤한 x, 0) 로 지정
            }
            else
            {
                pictureBox_expensiveCar.Top += speed;
            }

            if (pictureBox_expensiveCar2.Top >= 500)
            {
                x = r.Next(200, 400 - (pictureBox_expensiveCar2.Width));
                pictureBox_expensiveCar2.Location = new Point(x, 0);
            }
            else
            {
                pictureBox_expensiveCar2.Top += speed;
            }
        }

        void GameOver() //Car가 expensiveCar 또는 expensiveCar2 와 교차했을 때 label_gameOver를 켜준다
        {
            if (pictureBox_Car.Bounds.IntersectsWith(pictureBox_expensiveCar.Bounds)) //Car.Bounds 가 expensiveCar.Bounds 와 교차했을 때
            {
                timer1.Enabled = false; //메서드를 timer에서 호출했기 때문에 timer를 멈춤으로써 모든 메서드의 호출을 중단
                label_gameOver.Visible = true; //gameOver의 Visible 을 true로 설정함으로써 눈에 보이게 함
            }
            if (pictureBox_Car.Bounds.IntersectsWith(pictureBox_expensiveCar2.Bounds)) //Car.Bounds 가 expensiveCar.Bounds2 와 교차했을 때
            {
                timer1.Enabled = false;
                label_gameOver.Visible = true;
            }
        }

        void Coins(int speed)
        {
            //coin1 랜덤생성
            if (pictureBox_coin1.Top >= 500)
            {
                x = r.Next(0, 200);
                pictureBox_coin1.Location = new Point(x, 0);
            }
            else
            {
                pictureBox_coin1.Top += speed;
            }

            //coin2 랜덤생성
            if (pictureBox_coin2.Top >= 500)
            {
                x = r.Next(0, 200);
                pictureBox_coin2.Location = new Point(x, 0);
            }
            else
            {
                pictureBox_coin2.Top += speed;
            }

            //coin3 랜덤생성
            if (pictureBox_coin3.Top >= 500)
            {
                x = r.Next(0, 200);
                pictureBox_coin3.Location = new Point(x, 0);
            }
            else
            {
                pictureBox_coin3.Top += speed;
            }
        }

        int collectedCoin = 0;

        void coinsCollection()
        {

            //coin1
            if (pictureBox_Car.Bounds.IntersectsWith(pictureBox_coin1.Bounds))
            {
                collectedCoin++; //collectedCoin 증가 후 띄워주기
                label_coins.Text = "Coins = " + collectedCoin.ToString();

                x = r.Next(0, 200); //먹었을 때 재 생성
                pictureBox_coin1.Location = new Point(x, 0);
            }
            
            //coin2
            if (pictureBox_Car.Bounds.IntersectsWith(pictureBox_coin2.Bounds))
            {
                collectedCoin++; //collectedCoin 증가 후 띄워주기
                label_coins.Text = "Coins = " + collectedCoin.ToString();

                x = r.Next(0, 200); //먹었을 때 재 생성
                pictureBox_coin2.Location = new Point(x, 0);
            }

            //coin3
            if (pictureBox_Car.Bounds.IntersectsWith(pictureBox_coin3.Bounds))
            {
                collectedCoin++; //collectedCoin 증가 후 띄워주기
                label_coins.Text = "Coins = " + collectedCoin.ToString();

                x = r.Next(0, 200); //먹었을 때 재 생성
                pictureBox_coin3.Location = new Point(x, 0);
            }
        }  
    }
}
