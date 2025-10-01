using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class play : Form
    {
        int pipeSpeed = 5;
        int gravity = 5;
        int score = 0;
        int highScore = 0;

        // Boruların ve zeminin orijinal konumları
        private Point flappyBirdOriginalLocation;
        private Point upPipeOriginalLocation;
        private Point downPipeOriginalLocation;
        private Point upPipe2OriginalLocation;
        private Point downPipe2OriginalLocation;
        private Point upPipe3OriginalLocation;
        private Point downPipe3OriginalLocation;
        private Point groundOriginalLocation;

        // Game over kontrolleri
        private Panel gameOverPanel;
        private Label gameOverLabel;
        private Label scoreLabel;
        private Label highScoreLabel;
        private Button restartButton;
        private Button exitButton;

        public play()
        {
            InitializeComponent();

            // Form boyutunu sabitleme
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;

            // Orijinal konumları kaydetme
            SaveOriginalLocations();

            // Game over panelini oluşturma 
            CreateGameOverPanel();
        }

        private void CreateGameOverPanel()
        {
            // Game Over Paneli
            gameOverPanel = new Panel();
            gameOverPanel.Size = new Size(400, 300);
            gameOverPanel.BackColor = Color.FromArgb(200, 0, 0, 0); 
            gameOverPanel.Visible = false;
            gameOverPanel.Location = new Point(
                (this.ClientSize.Width - gameOverPanel.Width) / 2,
                (this.ClientSize.Height - gameOverPanel.Height) / 2
            );

            // Game Over Labeli
            gameOverLabel = new Label();
            gameOverLabel.Text = "GAME OVER";
            gameOverLabel.Font = new Font("Arial", 24, FontStyle.Bold);
            gameOverLabel.ForeColor = Color.White;
            gameOverLabel.AutoSize = true;
            gameOverLabel.Location = new Point(
                (gameOverPanel.Width - gameOverLabel.Width) / 2,
                20
            );

            // Score Labeli
            scoreLabel = new Label();
            scoreLabel.Font = new Font("Arial", 16, FontStyle.Regular);
            scoreLabel.ForeColor = Color.White;
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(
                (gameOverPanel.Width - scoreLabel.Width) / 2,
                80
            );

            // High Score Labeli
            highScoreLabel = new Label();
            highScoreLabel.Font = new Font("Arial", 14, FontStyle.Regular);
            highScoreLabel.ForeColor = Color.Gold;
            highScoreLabel.AutoSize = true;
            highScoreLabel.Location = new Point(
                (gameOverPanel.Width - highScoreLabel.Width) / 2,
                120
            );

            // Restart Buttoni
            restartButton = new Button();
            restartButton.Text = "RESTART";
            restartButton.Size = new Size(150, 40);
            restartButton.Font = new Font("Arial", 12, FontStyle.Bold);
            restartButton.BackColor = Color.FromArgb(46, 204, 113);
            restartButton.ForeColor = Color.White;
            restartButton.FlatStyle = FlatStyle.Flat;
            restartButton.FlatAppearance.BorderSize = 0;
            restartButton.Cursor = Cursors.Hand;
            restartButton.Location = new Point(
                (gameOverPanel.Width - restartButton.Width) / 2,
                170
            );
            restartButton.Click += (s, e) => { resetGame(); };

            // Exit Buttonu
            exitButton = new Button();
            exitButton.Text = "EXIT";
            exitButton.Size = new Size(150, 40);
            exitButton.Font = new Font("Arial", 12, FontStyle.Bold);
            exitButton.BackColor = Color.FromArgb(231, 76, 60);
            exitButton.ForeColor = Color.White;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.Cursor = Cursors.Hand;
            exitButton.Location = new Point(
                (gameOverPanel.Width - exitButton.Width) / 2,
                220
            );
            exitButton.Click += (s, e) => { Application.Exit(); };

            // Buton hover efektleri
            restartButton.MouseEnter += (s, e) => { restartButton.BackColor = Color.FromArgb(39, 174, 96); };
            restartButton.MouseLeave += (s, e) => { restartButton.BackColor = Color.FromArgb(46, 204, 113); };
            exitButton.MouseEnter += (s, e) => { exitButton.BackColor = Color.FromArgb(192, 57, 43); };
            exitButton.MouseLeave += (s, e) => { exitButton.BackColor = Color.FromArgb(231, 76, 60); };

            // Panelin klavye olaylarını engellemesini önleme
            gameOverPanel.KeyDown += gamekeyisdown;
            gameOverPanel.KeyUp += gamekeyisup;
            restartButton.KeyDown += gamekeyisdown;
            restartButton.KeyUp += gamekeyisup;
            exitButton.KeyDown += gamekeyisdown;
            exitButton.KeyUp += gamekeyisup;

            // Panelin klavye odak alabilmesini sağlama
            gameOverPanel.TabStop = true;

            // Kontrolleri paneli
            gameOverPanel.Controls.Add(gameOverLabel);
            gameOverPanel.Controls.Add(scoreLabel);
            gameOverPanel.Controls.Add(highScoreLabel);
            gameOverPanel.Controls.Add(restartButton);
            gameOverPanel.Controls.Add(exitButton);

            // Panelı forma ekleme
            this.Controls.Add(gameOverPanel);
            gameOverPanel.BringToFront();
        }

        private void SaveOriginalLocations()
        {
            flappyBirdOriginalLocation = flappyBird.Location;
            upPipeOriginalLocation = upPipe.Location;
            downPipeOriginalLocation = downPipe.Location;
            upPipe2OriginalLocation = upPipe2.Location;
            downPipe2OriginalLocation = downPipe2.Location;
            upPipe3OriginalLocation = upPipe3.Location;
            downPipe3OriginalLocation = downPipe3.Location;
            groundOriginalLocation = ground.Location;
        }

        private void play_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // Sadece oyun çalışırken kuşu hareket ettirir
                if (timerGame.Enabled && !gameOverPanel.Visible)
                {
                    flappyBird.Top -= 60;
                }
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            
        }

        private void Timer(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            upPipe.Left -= pipeSpeed;
            downPipe.Left -= pipeSpeed;
            upPipe2.Left -= pipeSpeed;
            downPipe2.Left -= pipeSpeed;
            upPipe3.Left -= pipeSpeed;
            downPipe3.Left -= pipeSpeed;
            ground.Left -= pipeSpeed;   

            // Score text'i güncelleme - High Score'u da gösterme
            ScoreText.Text = $"Score: {score} | High Score: {highScore}";

            // --- Boru Seti 1 ---
            if (upPipe.Left < -100)
            {
                upPipe.Left = 800;
                downPipe.Left = 800;
                score++;
            }
            // --- Boru Seti 2 ---
            if (upPipe2.Left < -100)
            {
                upPipe2.Left = 800;
                downPipe2.Left = 800;
                score++;
            }
            // --- Boru Seti 3 ---
            if (upPipe3.Left < -100)
            {
                upPipe3.Left = 800;
                downPipe3.Left = 800;
                score++;
            }
            // --- Zemin ---
            if (ground.Left < -100)
            {   ground.Left = 0; }

            // Çarpışma kontrolleri
            if (flappyBird.Bounds.IntersectsWith(upPipe.Bounds) ||
              flappyBird.Bounds.IntersectsWith(downPipe.Bounds) ||
              flappyBird.Bounds.IntersectsWith(upPipe2.Bounds) ||
              flappyBird.Bounds.IntersectsWith(downPipe2.Bounds) ||
              flappyBird.Bounds.IntersectsWith(upPipe3.Bounds) ||
              flappyBird.Bounds.IntersectsWith(downPipe3.Bounds) ||
              flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
              flappyBird.Top < -20)
            {
                endGame();
            }

            // Zorluk seviyesi artışları
            if (score > 5)
            {
                pipeSpeed = 6;
                gravity = 6;
            }
            if (score > 10)
            {
                pipeSpeed = 8;
                gravity = 7;
            }
            if (score > 20)
            {
                pipeSpeed = 10;
                gravity = 8;
            }
        }

        private void endGame()
        {
            timerGame.Stop();

            // High score'u güncelleme
            if (score > highScore)
            {
                highScore = score;
            }

            // Game over panelini güncelleme ve gösterme
            scoreLabel.Text = $"Your Score: {score}";
            highScoreLabel.Text = $"High Score: {highScore}";

            // Label konumları
            scoreLabel.Location = new Point((gameOverPanel.Width - scoreLabel.Width) / 2, 80);
            highScoreLabel.Location = new Point((gameOverPanel.Width - highScoreLabel.Width) / 2, 120);

            gameOverPanel.Visible = true;

          //Klavye odağı
            this.Focus();
        }

        private void resetGame()
        {
            // Game over panelini gizleme
            gameOverPanel.Visible = false;

            // Timer'ı durdurma ve değişkenleri sıfırlama
            timerGame.Stop();
            gravity = 5;
            pipeSpeed = 5;
            score = 0;

            // Tüm kontrolleri orijinal konumlarına sıfırlama
            flappyBird.Location = flappyBirdOriginalLocation;
            upPipe.Location = upPipeOriginalLocation;
            downPipe.Location = downPipeOriginalLocation;
            upPipe2.Location = upPipe2OriginalLocation;
            downPipe2.Location = downPipe2OriginalLocation;
            upPipe3.Location = upPipe3OriginalLocation;
            downPipe3.Location = downPipe3OriginalLocation;
            ground.Location = groundOriginalLocation;

            // Skor metnini sıfırlama (High score korunur)
            ScoreText.Text = $"Score: 0 | High Score: {highScore}";

            // Klavye odağı
            this.Focus();

            // Timer'ı yeniden başlatma
            timerGame.Start();
        }

        private void ground_Click(object sender, EventArgs e)
        {
            // ...
        }

        private void downPipe_Click(object sender, EventArgs e)
        {

        }
    }
}