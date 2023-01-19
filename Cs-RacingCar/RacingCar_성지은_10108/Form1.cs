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
        int bossSpeed = 5;

        public Form1()
        {
            InitializeComponent();
        }

        int carSpeed = 0;

        void MoveLine(int speed) //pictureBox 가 화면에서 사라지면 다시 위로 끌어올림
        {
            if (line1.Top >= 500)
            {
                line1.Top = 0;
            }
            else
            {
                line1.Top += speed;
            }

            if (line2.Top >= 500)
            {
                line2.Top = 0;
            }
            else
            {
                line2.Top += speed;
            }

            if (line3.Top >= 500)
            {
                line3.Top = 0;
            }
            else
            {
                line3.Top += speed;
            }
        }

        private void default_Tick(object sender, EventArgs e) //100분의 1초마다 Tick, event 발생 즉 100분의 1초마다 MoveLine() 호출
        {
            MoveLine(carSpeed);
            Enemy(carSpeed);
            GameOver();
            Coins(carSpeed);
            CoinsCollection();
            booster(carSpeed);
            autoStop();
            HP();
        }
        void HP()
        {
            if (carHP == 0)
            {
                HP1.Visible = false;
                HP2.Visible = false;
                HP3.Visible = false;
                HP4.Visible = false;
                HP5.Visible = false;
            }
            if (carHP == 1)
            {
                HP1.Visible = true;
                HP2.Visible = false;
                HP3.Visible = false;
                HP4.Visible = false;
                HP5.Visible = false;
            }
            if (carHP == 2)
            {
                HP1.Visible = true;
                HP2.Visible = true;
                HP3.Visible = false;
                HP4.Visible = false;
                HP5.Visible = false;
            }
            if (carHP == 3)
            {
                HP1.Visible = true;
                HP2.Visible = true;
                HP3.Visible = true;
                HP4.Visible = false;
                HP5.Visible = false;
            }
            if (carHP == 4)
            {
                HP1.Visible = true;
                HP2.Visible = true;
                HP3.Visible = true;
                HP4.Visible = true;
                HP5.Visible = false;
            }
            if (carHP == 5)
            {
                HP1.Visible = true;
                HP2.Visible = true;
                HP3.Visible = true;
                HP4.Visible = true;
                HP5.Visible = true;
            }

        }

        int carHP = 5;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.G)
            {
                timer1.Enabled = true;
                boostertime.Enabled = false;
                carSpeed = 0;

                isBooster = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                if (player.Left > 0) //벽뚫 방지
                    player.Left += -10;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (player.Right < 400 - player.Width / 2)
                    player.Left += 10;
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

        void Enemy(int speed) //expensiveCar이 화면에서 사라지면 끌어올림 //= MoveLine()
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(0, 200); //pictureBox_expensiveCar 의 좌표가 겹치지 않도록 설정
                enemy1.Location = new Point(x, 0); //expensiveCar 의 위치를 (랜덤한 x, 0) 로 지정
            }
            else
            {
                enemy1.Top += speed;
            }

            if (enemy2.Top >= 500)
            {
                x = r.Next(200, 400 - (enemy2.Width));
                enemy2.Location = new Point(x, 0);
            }

            if (Boss.Top >= 500)
            {
                x = r.Next(0, 300);
                Boss.Location = new Point(x, 0);

                _currentTime = 0;
            }
        }

        void GameOver() //Car가 expensiveCar 또는 expensiveCar2 와 교차했을 때 label_gameOver를 켜준다
        {
            if (player.Bounds.IntersectsWith(enemy1.Bounds)) //Car.Bounds 가 expensiveCar.Bounds 와 교차했을 때
            {
                carHP--; //gameOver의 Visible 을 true로 설정함으로써 눈에 보이게 함
                x = r.Next(0, 200); //pictureBox_expensiveCar 의 좌표가 겹치지 않도록 설정
                enemy1.Location = new Point(x, 0);
            }
            if (player.Bounds.IntersectsWith(enemy2.Bounds)) //Car.Bounds 가 expensiveCar.Bounds2 와 교차했을 때
            {
                carHP--;
                x = r.Next(200, 400 - (enemy2.Width));
                enemy2.Location = new Point(x, 0);
            }

            if (Boss.Bounds.IntersectsWith(player.Bounds))
            {
                carHP--;
                x = r.Next(0, 300);
                Boss.Location = new Point(x, 0);
            }

            if(carHP <= 0)
            {
                timer1.Enabled = false;
                label_gameOver.Visible = true;

                button_restart.Enabled = true;
                button_restart.Visible = true;
            }
        }

        void Coins(int speed)
        {
            //coin1 랜덤생성
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 200);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }

            //coin2 랜덤생성
            if (coin2.Top >= 500)
            {
                x = r.Next(0, 200);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }

            //coin3 랜덤생성
            if (coin3.Top >= 500)
            {
                x = r.Next(0, 200);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }
        }

        int collectedCoin = 0;

        void CoinsCollection()
        {

            //coin1
            if (player.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedCoin++; //collectedCoin 증가 후 띄워주기
                label_coins.Text = "Coins = " + collectedCoin.ToString();

                x = r.Next(0, 200); //먹었을 때 재 생성
                coin1.Location = new Point(x, 0);
            }
            
            //coin2
            if (player.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedCoin++; //collectedCoin 증가 후 띄워주기
                label_coins.Text = "Coins = " + collectedCoin.ToString();

                x = r.Next(0, 200); //먹었을 때 재 생성
                coin2.Location = new Point(x, 0);
            }

            //coin3
            if (player.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedCoin++; //collectedCoin 증가 후 띄워주기
                label_coins.Text = "Coins = " + collectedCoin.ToString();

                x = r.Next(0, 200); //먹었을 때 재 생성
                coin3.Location = new Point(x, 0);
            }
        }

        void booster(int speed)
        {
            if (boosterBox.Top >= 500)
            {
                x = r.Next(0, 200);
                boosterBox.Location = new Point(x, 0);
            }
            else
            {
                boosterBox.Top += speed;
            }


            if (player.Bounds.IntersectsWith(boosterBox.Bounds) && isBooster == false)
            {
                timer1.Enabled = false;
                boostertime.Enabled = true;
                carSpeed = 30;
                currentTime = 0;
            }
        }

        bool isBooster = false;

        float currentTime = 0;
        float stopTime = 3;

        void autoStop()
        {
            if(currentTime >= stopTime)
            {
                timer1.Enabled = true;
                boostertime.Enabled = false;
                carSpeed = 0;

                isBooster = true;
            }
        }

        void fireVisible()
        {
            if (boostertime.Enabled)
            {
                boosterFire.Visible = true;
                boosterFire.Top = player.Bounds.Bottom;
                boosterFire.Left = player.Bounds.Left;
            }
        }

        private void boostertime_Tick(object sender, EventArgs e)
        {
            CoinsCollection();
            Coins(carSpeed);
            MoveLine(carSpeed);
            booster(carSpeed);
            fireVisible();
            BossMove(bossSpeed);
            Enemy(carSpeed);
        }

        float _currentTime = 0;
        float maxTime = 50;

        bool moveLeft = false;

        void BossMove(int speed)
        {

            if (Boss.Left > 0 && moveLeft == false)
            {
                Boss.Left += -speed;
                _currentTime += 0.1f;
                if (_currentTime > maxTime)
                {
                    Boss.Top += speed * 2;

                    moveLeft = true;
                }

                if (Boss.Left <= 0)
                {
                    moveLeft = true;
                }
            }

            if (Boss.Left < 300 && moveLeft == true)
            {
                Boss.Left += speed;

                _currentTime += 0.1f;

                if (_currentTime > maxTime)
                {
                    Boss.Top += speed * 2;

                    moveLeft = false;
                }

                if (Boss.Left >= 300)
                {
                    moveLeft = false;
                }
            }

        }


        private void timer2_Tick(object sender, EventArgs e)
        {

            currentTime++;

        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label_gameOver.Visible = false;
            carHP = 5;

            button_restart.Enabled = false;
            button_restart.Visible = false;

            collectedCoin = 0;
        }
    }
}
