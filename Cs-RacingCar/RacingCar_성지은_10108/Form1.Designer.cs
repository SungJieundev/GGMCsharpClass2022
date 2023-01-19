namespace RacingCar_성지은_10108
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.line1 = new System.Windows.Forms.PictureBox();
            this.rightLine = new System.Windows.Forms.PictureBox();
            this.leftLine = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.line2 = new System.Windows.Forms.PictureBox();
            this.line3 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.label_gameOver = new System.Windows.Forms.Label();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.label_coins = new System.Windows.Forms.Label();
            this.boosterBox = new System.Windows.Forms.PictureBox();
            this.boostertime = new System.Windows.Forms.Timer(this.components);
            this.boosterFire = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.HP1 = new System.Windows.Forms.PictureBox();
            this.HP2 = new System.Windows.Forms.PictureBox();
            this.HP3 = new System.Windows.Forms.PictureBox();
            this.HP4 = new System.Windows.Forms.PictureBox();
            this.HP5 = new System.Windows.Forms.PictureBox();
            this.button_restart = new System.Windows.Forms.Button();
            this.Boss = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boosterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boosterFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HP4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HP5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boss)).BeginInit();
            this.SuspendLayout();
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.White;
            this.line1.Location = new System.Drawing.Point(190, -97);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(14, 123);
            this.line1.TabIndex = 0;
            this.line1.TabStop = false;
            // 
            // rightLine
            // 
            this.rightLine.BackColor = System.Drawing.Color.White;
            this.rightLine.Location = new System.Drawing.Point(373, 0);
            this.rightLine.Name = "rightLine";
            this.rightLine.Size = new System.Drawing.Size(11, 463);
            this.rightLine.TabIndex = 4;
            this.rightLine.TabStop = false;
            // 
            // leftLine
            // 
            this.leftLine.BackColor = System.Drawing.Color.White;
            this.leftLine.Location = new System.Drawing.Point(-2, 0);
            this.leftLine.Name = "leftLine";
            this.leftLine.Size = new System.Drawing.Size(11, 463);
            this.leftLine.TabIndex = 5;
            this.leftLine.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.default_Tick);
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.White;
            this.line2.Location = new System.Drawing.Point(190, 117);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(14, 123);
            this.line2.TabIndex = 6;
            this.line2.TabStop = false;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.White;
            this.line3.Location = new System.Drawing.Point(190, 340);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(14, 123);
            this.line3.TabIndex = 7;
            this.line3.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(82, 328);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(65, 40);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.enemy1.TabIndex = 8;
            this.enemy1.TabStop = false;
            // 
            // player
            // 
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(238, 351);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(33, 66);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.player.TabIndex = 9;
            this.player.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(185, 150);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(65, 40);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.enemy2.TabIndex = 10;
            this.enemy2.TabStop = false;
            // 
            // label_gameOver
            // 
            this.label_gameOver.AutoSize = true;
            this.label_gameOver.BackColor = System.Drawing.Color.Transparent;
            this.label_gameOver.Font = new System.Drawing.Font("휴먼모음T", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gameOver.ForeColor = System.Drawing.Color.Red;
            this.label_gameOver.Location = new System.Drawing.Point(15, 183);
            this.label_gameOver.Name = "label_gameOver";
            this.label_gameOver.Size = new System.Drawing.Size(334, 67);
            this.label_gameOver.TabIndex = 11;
            this.label_gameOver.Text = "Game Over";
            this.label_gameOver.Visible = false;
            // 
            // coin1
            // 
            this.coin1.Image = ((System.Drawing.Image)(resources.GetObject("coin1.Image")));
            this.coin1.Location = new System.Drawing.Point(185, 285);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(52, 49);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 12;
            this.coin1.TabStop = false;
            // 
            // coin3
            // 
            this.coin3.Image = ((System.Drawing.Image)(resources.GetObject("coin3.Image")));
            this.coin3.Location = new System.Drawing.Point(82, 104);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(52, 49);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 13;
            this.coin3.TabStop = false;
            // 
            // coin2
            // 
            this.coin2.Image = ((System.Drawing.Image)(resources.GetObject("coin2.Image")));
            this.coin2.Location = new System.Drawing.Point(297, 71);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(52, 49);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 14;
            this.coin2.TabStop = false;
            // 
            // label_coins
            // 
            this.label_coins.AutoSize = true;
            this.label_coins.Font = new System.Drawing.Font("예스체", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_coins.Location = new System.Drawing.Point(1, 0);
            this.label_coins.Name = "label_coins";
            this.label_coins.Size = new System.Drawing.Size(157, 40);
            this.label_coins.TabIndex = 15;
            this.label_coins.Text = "Coins = 0";
            // 
            // boosterBox
            // 
            this.boosterBox.Image = ((System.Drawing.Image)(resources.GetObject("boosterBox.Image")));
            this.boosterBox.Location = new System.Drawing.Point(258, 284);
            this.boosterBox.Name = "boosterBox";
            this.boosterBox.Size = new System.Drawing.Size(49, 50);
            this.boosterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boosterBox.TabIndex = 16;
            this.boosterBox.TabStop = false;
            // 
            // boostertime
            // 
            this.boostertime.Interval = 10;
            this.boostertime.Tick += new System.EventHandler(this.boostertime_Tick);
            // 
            // boosterFire
            // 
            this.boosterFire.Image = ((System.Drawing.Image)(resources.GetObject("boosterFire.Image")));
            this.boosterFire.Location = new System.Drawing.Point(238, 414);
            this.boosterFire.Name = "boosterFire";
            this.boosterFire.Size = new System.Drawing.Size(34, 75);
            this.boosterFire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.boosterFire.TabIndex = 17;
            this.boosterFire.TabStop = false;
            this.boosterFire.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // HP1
            // 
            this.HP1.Image = ((System.Drawing.Image)(resources.GetObject("HP1.Image")));
            this.HP1.Location = new System.Drawing.Point(13, 44);
            this.HP1.Name = "HP1";
            this.HP1.Size = new System.Drawing.Size(29, 29);
            this.HP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HP1.TabIndex = 18;
            this.HP1.TabStop = false;
            // 
            // HP2
            // 
            this.HP2.Image = ((System.Drawing.Image)(resources.GetObject("HP2.Image")));
            this.HP2.Location = new System.Drawing.Point(48, 44);
            this.HP2.Name = "HP2";
            this.HP2.Size = new System.Drawing.Size(29, 29);
            this.HP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HP2.TabIndex = 19;
            this.HP2.TabStop = false;
            // 
            // HP3
            // 
            this.HP3.Image = ((System.Drawing.Image)(resources.GetObject("HP3.Image")));
            this.HP3.Location = new System.Drawing.Point(83, 44);
            this.HP3.Name = "HP3";
            this.HP3.Size = new System.Drawing.Size(29, 29);
            this.HP3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HP3.TabIndex = 20;
            this.HP3.TabStop = false;
            // 
            // HP4
            // 
            this.HP4.Image = ((System.Drawing.Image)(resources.GetObject("HP4.Image")));
            this.HP4.Location = new System.Drawing.Point(118, 44);
            this.HP4.Name = "HP4";
            this.HP4.Size = new System.Drawing.Size(29, 29);
            this.HP4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HP4.TabIndex = 21;
            this.HP4.TabStop = false;
            // 
            // HP5
            // 
            this.HP5.Image = ((System.Drawing.Image)(resources.GetObject("HP5.Image")));
            this.HP5.Location = new System.Drawing.Point(153, 44);
            this.HP5.Name = "HP5";
            this.HP5.Size = new System.Drawing.Size(29, 29);
            this.HP5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HP5.TabIndex = 22;
            this.HP5.TabStop = false;
            // 
            // button_restart
            // 
            this.button_restart.Enabled = false;
            this.button_restart.Location = new System.Drawing.Point(128, 254);
            this.button_restart.Name = "button_restart";
            this.button_restart.Size = new System.Drawing.Size(75, 23);
            this.button_restart.TabIndex = 23;
            this.button_restart.Text = "button1";
            this.button_restart.UseVisualStyleBackColor = true;
            this.button_restart.Visible = false;
            this.button_restart.Click += new System.EventHandler(this.button_restart_Click);
            // 
            // Boss
            // 
            this.Boss.Image = global::RacingCar_성지은_10108.Properties.Resources.car__2_;
            this.Boss.Location = new System.Drawing.Point(153, -18);
            this.Boss.Name = "Boss";
            this.Boss.Size = new System.Drawing.Size(85, 91);
            this.Boss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Boss.TabIndex = 24;
            this.Boss.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.Boss);
            this.Controls.Add(this.button_restart);
            this.Controls.Add(this.HP5);
            this.Controls.Add(this.HP4);
            this.Controls.Add(this.HP3);
            this.Controls.Add(this.HP2);
            this.Controls.Add(this.HP1);
            this.Controls.Add(this.boosterFire);
            this.Controls.Add(this.boosterBox);
            this.Controls.Add(this.label_coins);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.label_gameOver);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.player);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.leftLine);
            this.Controls.Add(this.rightLine);
            this.Controls.Add(this.line1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.line1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boosterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boosterFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HP4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HP5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox line1;
        private System.Windows.Forms.PictureBox rightLine;
        private System.Windows.Forms.PictureBox leftLine;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox line2;
        private System.Windows.Forms.PictureBox line3;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Label label_gameOver;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.Label label_coins;
        private System.Windows.Forms.PictureBox boosterBox;
        private System.Windows.Forms.Timer boostertime;
        private System.Windows.Forms.PictureBox boosterFire;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox HP1;
        private System.Windows.Forms.PictureBox HP2;
        private System.Windows.Forms.PictureBox HP3;
        private System.Windows.Forms.PictureBox HP4;
        private System.Windows.Forms.PictureBox HP5;
        private System.Windows.Forms.Button button_restart;
        private System.Windows.Forms.PictureBox Boss;
    }
}

