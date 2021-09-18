
namespace game2
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_car = new System.Windows.Forms.PictureBox();
            this.pictureBox_barrier = new System.Windows.Forms.PictureBox();
            this.pictureBox_barrier2 = new System.Windows.Forms.PictureBox();
            this.label_coin = new System.Windows.Forms.Label();
            this.label_gameover = new System.Windows.Forms.Label();
            this.pictureBox_coin2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_coin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_barrier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_barrier2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_coin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Location = new System.Drawing.Point(234, -129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 211);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(234, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 162);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Location = new System.Drawing.Point(234, 290);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 159);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.Location = new System.Drawing.Point(234, 483);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(18, 163);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox_car
            // 
            this.pictureBox_car.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_car.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_car.Image")));
            this.pictureBox_car.Location = new System.Drawing.Point(117, 404);
            this.pictureBox_car.Name = "pictureBox_car";
            this.pictureBox_car.Size = new System.Drawing.Size(50, 75);
            this.pictureBox_car.TabIndex = 4;
            this.pictureBox_car.TabStop = false;
            // 
            // pictureBox_barrier
            // 
            this.pictureBox_barrier.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_barrier.Image")));
            this.pictureBox_barrier.Location = new System.Drawing.Point(389, 122);
            this.pictureBox_barrier.Name = "pictureBox_barrier";
            this.pictureBox_barrier.Size = new System.Drawing.Size(71, 94);
            this.pictureBox_barrier.TabIndex = 7;
            this.pictureBox_barrier.TabStop = false;
            this.pictureBox_barrier.Click += new System.EventHandler(this.pictureBox_barrier_Click);
            // 
            // pictureBox_barrier2
            // 
            this.pictureBox_barrier2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_barrier2.Image")));
            this.pictureBox_barrier2.Location = new System.Drawing.Point(96, 113);
            this.pictureBox_barrier2.Name = "pictureBox_barrier2";
            this.pictureBox_barrier2.Size = new System.Drawing.Size(71, 94);
            this.pictureBox_barrier2.TabIndex = 8;
            this.pictureBox_barrier2.TabStop = false;
            // 
            // label_coin
            // 
            this.label_coin.AutoSize = true;
            this.label_coin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_coin.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_coin.Location = new System.Drawing.Point(12, 21);
            this.label_coin.Name = "label_coin";
            this.label_coin.Size = new System.Drawing.Size(107, 21);
            this.label_coin.TabIndex = 9;
            this.label_coin.Text = "coins=0";
            // 
            // label_gameover
            // 
            this.label_gameover.AutoSize = true;
            this.label_gameover.Font = new System.Drawing.Font("휴먼둥근헤드라인", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_gameover.ForeColor = System.Drawing.Color.Red;
            this.label_gameover.Location = new System.Drawing.Point(87, 237);
            this.label_gameover.Name = "label_gameover";
            this.label_gameover.Size = new System.Drawing.Size(340, 50);
            this.label_gameover.TabIndex = 10;
            this.label_gameover.Text = "game over";
            this.label_gameover.Visible = false;
            // 
            // pictureBox_coin2
            // 
            this.pictureBox_coin2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_coin2.Image")));
            this.pictureBox_coin2.Location = new System.Drawing.Point(161, 31);
            this.pictureBox_coin2.Name = "pictureBox_coin2";
            this.pictureBox_coin2.Size = new System.Drawing.Size(67, 61);
            this.pictureBox_coin2.TabIndex = 12;
            this.pictureBox_coin2.TabStop = false;
            // 
            // pictureBox_coin
            // 
            this.pictureBox_coin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_coin.Image")));
            this.pictureBox_coin.Location = new System.Drawing.Point(295, 85);
            this.pictureBox_coin.Name = "pictureBox_coin";
            this.pictureBox_coin.Size = new System.Drawing.Size(67, 61);
            this.pictureBox_coin.TabIndex = 13;
            this.pictureBox_coin.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "control speed by keyboard arrow";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(482, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_coin);
            this.Controls.Add(this.pictureBox_coin2);
            this.Controls.Add(this.label_gameover);
            this.Controls.Add(this.label_coin);
            this.Controls.Add(this.pictureBox_barrier2);
            this.Controls.Add(this.pictureBox_barrier);
            this.Controls.Add(this.pictureBox_car);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_barrier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_barrier2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_coin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox_car;
        private System.Windows.Forms.PictureBox pictureBox_barrier;
        private System.Windows.Forms.PictureBox pictureBox_barrier2;
        private System.Windows.Forms.Label label_coin;
        private System.Windows.Forms.Label label_gameover;
        private System.Windows.Forms.PictureBox pictureBox_coin2;
        private System.Windows.Forms.PictureBox pictureBox_coin;
        private System.Windows.Forms.Label label1;
    }
}

