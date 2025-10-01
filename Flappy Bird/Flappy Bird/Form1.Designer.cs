namespace Flappy_Bird
{
    partial class play
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.ScoreText = new System.Windows.Forms.Label();
            this.pictureBoxArray1 = new Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(this.components);
            this.labelArray1 = new Microsoft.VisualBasic.Compatibility.VB6.LabelArray(this.components);
            this.ground = new System.Windows.Forms.PictureBox();
            this.downPipe = new System.Windows.Forms.PictureBox();
            this.upPipe = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.upPipe2 = new System.Windows.Forms.PictureBox();
            this.downPipe2 = new System.Windows.Forms.PictureBox();
            this.upPipe3 = new System.Windows.Forms.PictureBox();
            this.downPipe3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArray1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelArray1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPipe3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPipe3)).BeginInit();
            this.SuspendLayout();
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 20;
            this.timerGame.Tick += new System.EventHandler(this.Timer);
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ScoreText.Location = new System.Drawing.Point(12, 705);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(134, 32);
            this.ScoreText.TabIndex = 4;
            this.ScoreText.Text = "SCORE: 0";
            // 
            // ground
            // 
            this.ground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ground.Image = global::Flappy_Bird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-20, 676);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1351, 84);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            this.ground.Click += new System.EventHandler(this.ground_Click);
            // 
            // downPipe
            // 
            this.downPipe.Image = global::Flappy_Bird.Properties.Resources.downPipe;
            this.downPipe.Location = new System.Drawing.Point(392, 398);
            this.downPipe.Name = "downPipe";
            this.downPipe.Size = new System.Drawing.Size(88, 283);
            this.downPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.downPipe.TabIndex = 1;
            this.downPipe.TabStop = false;
            this.downPipe.Click += new System.EventHandler(this.downPipe_Click);
            // 
            // upPipe
            // 
            this.upPipe.Image = global::Flappy_Bird.Properties.Resources.upPipe;
            this.upPipe.Location = new System.Drawing.Point(392, 1);
            this.upPipe.Name = "upPipe";
            this.upPipe.Size = new System.Drawing.Size(88, 224);
            this.upPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upPipe.TabIndex = 0;
            this.upPipe.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::Flappy_Bird.Properties.Resources.redbird_midflap;
            this.flappyBird.Location = new System.Drawing.Point(18, 254);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(57, 44);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 3;
            this.flappyBird.TabStop = false;
            // 
            // upPipe2
            // 
            this.upPipe2.Image = global::Flappy_Bird.Properties.Resources.upPipe;
            this.upPipe2.Location = new System.Drawing.Point(817, 1);
            this.upPipe2.Name = "upPipe2";
            this.upPipe2.Size = new System.Drawing.Size(88, 140);
            this.upPipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upPipe2.TabIndex = 5;
            this.upPipe2.TabStop = false;
            // 
            // downPipe2
            // 
            this.downPipe2.Image = global::Flappy_Bird.Properties.Resources.downPipe;
            this.downPipe2.Location = new System.Drawing.Point(817, 317);
            this.downPipe2.Name = "downPipe2";
            this.downPipe2.Size = new System.Drawing.Size(88, 364);
            this.downPipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.downPipe2.TabIndex = 6;
            this.downPipe2.TabStop = false;
            // 
            // upPipe3
            // 
            this.upPipe3.Image = global::Flappy_Bird.Properties.Resources.upPipe;
            this.upPipe3.Location = new System.Drawing.Point(1247, 1);
            this.upPipe3.Name = "upPipe3";
            this.upPipe3.Size = new System.Drawing.Size(88, 280);
            this.upPipe3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upPipe3.TabIndex = 7;
            this.upPipe3.TabStop = false;
            // 
            // downPipe3
            // 
            this.downPipe3.Image = global::Flappy_Bird.Properties.Resources.downPipe;
            this.downPipe3.Location = new System.Drawing.Point(1247, 473);
            this.downPipe3.Name = "downPipe3";
            this.downPipe3.Size = new System.Drawing.Size(88, 208);
            this.downPipe3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.downPipe3.TabIndex = 8;
            this.downPipe3.TabStop = false;
            // 
            // play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(639, 759);
            this.Controls.Add(this.upPipe3);
            this.Controls.Add(this.upPipe2);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.upPipe);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.downPipe);
            this.Controls.Add(this.downPipe3);
            this.Controls.Add(this.downPipe2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "play";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.play_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArray1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelArray1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPipe3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPipe3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox upPipe;
        private System.Windows.Forms.PictureBox downPipe;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Label ScoreText;
        private Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray pictureBoxArray1;
        private Microsoft.VisualBasic.Compatibility.VB6.LabelArray labelArray1;
        private System.Windows.Forms.PictureBox upPipe2;
        private System.Windows.Forms.PictureBox downPipe2;
        private System.Windows.Forms.PictureBox upPipe3;
        private System.Windows.Forms.PictureBox downPipe3;
    }
}

