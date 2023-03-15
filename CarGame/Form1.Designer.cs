namespace CarGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.award = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.A1 = new System.Windows.Forms.PictureBox();
            this.A2 = new System.Windows.Forms.PictureBox();
            this.roadtruck2 = new System.Windows.Forms.PictureBox();
            this.roadtrack1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.textScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtruck2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.A1);
            this.panel1.Controls.Add(this.A2);
            this.panel1.Controls.Add(this.roadtruck2);
            this.panel1.Controls.Add(this.roadtrack1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 509);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // award
            // 
            this.award.Image = global::CarGame.Properties.Resources.hosgeldiin1;
            this.award.Location = new System.Drawing.Point(102, 216);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(235, 95);
            this.award.TabIndex = 3;
            this.award.TabStop = false;
            this.award.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // explosion
            // 
            this.explosion.Image = global::CarGame.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(102, 330);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosion.TabIndex = 6;
            this.explosion.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::CarGame.Properties.Resources.carYellow;
            this.player.Location = new System.Drawing.Point(193, 398);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 99);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // A1
            // 
            this.A1.Image = global::CarGame.Properties.Resources.carGreen;
            this.A1.Location = new System.Drawing.Point(48, 25);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(50, 101);
            this.A1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.A1.TabIndex = 3;
            this.A1.TabStop = false;
            this.A1.Tag = "carLeft";
            // 
            // A2
            // 
            this.A2.Image = global::CarGame.Properties.Resources.carOrange;
            this.A2.Location = new System.Drawing.Point(238, 75);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(50, 100);
            this.A2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.A2.TabIndex = 2;
            this.A2.TabStop = false;
            this.A2.Tag = "carRight";
            // 
            // roadtruck2
            // 
            this.roadtruck2.Image = global::CarGame.Properties.Resources.roadTrack_;
            this.roadtruck2.Location = new System.Drawing.Point(3, 3);
            this.roadtruck2.Name = "roadtruck2";
            this.roadtruck2.Size = new System.Drawing.Size(420, 578);
            this.roadtruck2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadtruck2.TabIndex = 1;
            this.roadtruck2.TabStop = false;
            this.roadtruck2.Click += new System.EventHandler(this.roadtruck2_Click);
            // 
            // roadtrack1
            // 
            this.roadtrack1.Image = global::CarGame.Properties.Resources.roadTrack;
            this.roadtrack1.Location = new System.Drawing.Point(3, 0);
            this.roadtrack1.Name = "roadtrack1";
            this.roadtrack1.Size = new System.Drawing.Size(420, 577);
            this.roadtrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadtrack1.TabIndex = 0;
            this.roadtrack1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(145, 542);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(123, 47);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Başla";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.restartGame);
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textScore.Location = new System.Drawing.Point(159, 512);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(84, 26);
            this.textScore.TabIndex = 2;
            this.textScore.Text = "Skor: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(419, 601);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Araba Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtruck2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btnStart;
        private PictureBox explosion;
        private PictureBox player;
        private PictureBox A1;
        private PictureBox A2;
        private PictureBox roadtrack1;
        private Label textScore;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox award;
        private PictureBox roadtruck2;
    }
}