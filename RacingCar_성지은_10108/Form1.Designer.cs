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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_expensiveCar = new System.Windows.Forms.PictureBox();
            this.pictureBox_Car = new System.Windows.Forms.PictureBox();
            this.pictureBox_expensiveCar2 = new System.Windows.Forms.PictureBox();
            this.label_gameOver = new System.Windows.Forms.Label();
            this.pictureBox_coin1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_coin3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_coin2 = new System.Windows.Forms.PictureBox();
            this.label_coins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_expensiveCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_expensiveCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_coin2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(190, -97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(373, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(11, 463);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(11, 463);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(190, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(14, 123);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(190, 340);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(14, 123);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox_expensiveCar
            // 
            this.pictureBox_expensiveCar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_expensiveCar.Image")));
            this.pictureBox_expensiveCar.Location = new System.Drawing.Point(82, -14);
            this.pictureBox_expensiveCar.Name = "pictureBox_expensiveCar";
            this.pictureBox_expensiveCar.Size = new System.Drawing.Size(65, 40);
            this.pictureBox_expensiveCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_expensiveCar.TabIndex = 8;
            this.pictureBox_expensiveCar.TabStop = false;
            // 
            // pictureBox_Car
            // 
            this.pictureBox_Car.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Car.Image")));
            this.pictureBox_Car.Location = new System.Drawing.Point(237, 375);
            this.pictureBox_Car.Name = "pictureBox_Car";
            this.pictureBox_Car.Size = new System.Drawing.Size(33, 66);
            this.pictureBox_Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Car.TabIndex = 9;
            this.pictureBox_Car.TabStop = false;
            // 
            // pictureBox_expensiveCar2
            // 
            this.pictureBox_expensiveCar2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_expensiveCar2.Image")));
            this.pictureBox_expensiveCar2.Location = new System.Drawing.Point(237, -14);
            this.pictureBox_expensiveCar2.Name = "pictureBox_expensiveCar2";
            this.pictureBox_expensiveCar2.Size = new System.Drawing.Size(65, 40);
            this.pictureBox_expensiveCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_expensiveCar2.TabIndex = 10;
            this.pictureBox_expensiveCar2.TabStop = false;
            // 
            // label_gameOver
            // 
            this.label_gameOver.AutoSize = true;
            this.label_gameOver.BackColor = System.Drawing.Color.Transparent;
            this.label_gameOver.Font = new System.Drawing.Font("휴먼모음T", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gameOver.ForeColor = System.Drawing.Color.Red;
            this.label_gameOver.Location = new System.Drawing.Point(15, 202);
            this.label_gameOver.Name = "label_gameOver";
            this.label_gameOver.Size = new System.Drawing.Size(334, 67);
            this.label_gameOver.TabIndex = 11;
            this.label_gameOver.Text = "Game Over";
            this.label_gameOver.Visible = false;
            // 
            // pictureBox_coin1
            // 
            this.pictureBox_coin1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_coin1.Image")));
            this.pictureBox_coin1.Location = new System.Drawing.Point(172, 220);
            this.pictureBox_coin1.Name = "pictureBox_coin1";
            this.pictureBox_coin1.Size = new System.Drawing.Size(52, 49);
            this.pictureBox_coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_coin1.TabIndex = 12;
            this.pictureBox_coin1.TabStop = false;
            // 
            // pictureBox_coin3
            // 
            this.pictureBox_coin3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_coin3.Image")));
            this.pictureBox_coin3.Location = new System.Drawing.Point(82, 74);
            this.pictureBox_coin3.Name = "pictureBox_coin3";
            this.pictureBox_coin3.Size = new System.Drawing.Size(52, 49);
            this.pictureBox_coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_coin3.TabIndex = 13;
            this.pictureBox_coin3.TabStop = false;
            // 
            // pictureBox_coin2
            // 
            this.pictureBox_coin2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_coin2.Image")));
            this.pictureBox_coin2.Location = new System.Drawing.Point(250, 12);
            this.pictureBox_coin2.Name = "pictureBox_coin2";
            this.pictureBox_coin2.Size = new System.Drawing.Size(52, 49);
            this.pictureBox_coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_coin2.TabIndex = 14;
            this.pictureBox_coin2.TabStop = false;
            // 
            // label_coins
            // 
            this.label_coins.AutoSize = true;
            this.label_coins.Font = new System.Drawing.Font("예스체", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_coins.Location = new System.Drawing.Point(15, 44);
            this.label_coins.Name = "label_coins";
            this.label_coins.Size = new System.Drawing.Size(157, 40);
            this.label_coins.TabIndex = 15;
            this.label_coins.Text = "Coins = 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.label_coins);
            this.Controls.Add(this.pictureBox_coin2);
            this.Controls.Add(this.pictureBox_coin3);
            this.Controls.Add(this.pictureBox_coin1);
            this.Controls.Add(this.label_gameOver);
            this.Controls.Add(this.pictureBox_expensiveCar2);
            this.Controls.Add(this.pictureBox_Car);
            this.Controls.Add(this.pictureBox_expensiveCar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_expensiveCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_expensiveCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_coin2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox_expensiveCar;
        private System.Windows.Forms.PictureBox pictureBox_Car;
        private System.Windows.Forms.PictureBox pictureBox_expensiveCar2;
        private System.Windows.Forms.Label label_gameOver;
        private System.Windows.Forms.PictureBox pictureBox_coin1;
        private System.Windows.Forms.PictureBox pictureBox_coin3;
        private System.Windows.Forms.PictureBox pictureBox_coin2;
        private System.Windows.Forms.Label label_coins;
    }
}

