namespace QuantumSerpent
{
    public partial class FrmGame : Form
    {
        Directions playerDirection = Directions.Right;
        readonly static Player player = new(40, 40, 10);
        readonly Label lblPlayer1Name = new();
        EventHandlers eventHandlers = new();
        GameState gameState = GameState.Paused;
        bool hasMoved = false;

        public FrmGame()
        {
            InitializeComponent();
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Game loop
            player.Move(playerDirection);
            ValidatePlayerPosition();
            canvas.Invalidate(); // Force redraw
            hasMoved = false;
        }
        private void ValidatePlayerPosition()
        {
            if (player.X < 0 || player.X >= canvas.Width || player.Y < 0 || player.Y >= canvas.Height)
            {
                eventHandlers.TriggerGameOver();
            }
            foreach (Position pos in player.Items.Skip(1))
            {
                if (pos.X == player.X && pos.Y == player.Y)
                {
                    eventHandlers.TriggerGameOver();
                }
            }
        }
        private void SetupPlayerNames()
        {
            lblPlayer1Name.Text = GameSettings.Player1_Name;
            lblPlayer1Name.Width = 0;
            lblPlayer1Name.Height = 0;
            lblPlayer1Name.AutoSize = true;
            lblPlayer1Name.ForeColor = Color.White;
            lblPlayer1Name.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblPlayer1Name.TextAlign = ContentAlignment.MiddleLeft;
            lblPlayer1Name.BackColor = Color.Transparent;
            lblPlayer1Name.BringToFront();
            canvas.Controls.Add(lblPlayer1Name);
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            GameSettings.Player1_Name = txtName1.Text;
            GameSettings.Player2_Name = txtName2.Text;
            GameSettings.Bot1 = chkBot1.Checked;
            GameSettings.Bot2 = chkBot2.Checked;

            txtName1.Enabled = false;
            txtName2.Enabled = false;
            chkBot1.Enabled = false;
            chkBot2.Enabled = false;
            btnDifficulty.Enabled = false;

            SetupPlayerNames();
            

            gameTimer.Interval = GameSettings.Difficulty switch
            {
                Difficulty.Easy => 200,
                Difficulty.Medium => 100,
                Difficulty.Hard => 50,
                _ => 200
            };
            gameTimer.Enabled = true;
            btnStart.Enabled = false;
            gameState = GameState.Running;
        }
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            // Draw the whole game situation
            Graphics graphics = e.Graphics;

            // Draw the player
            if (gameState == GameState.Running)
            {
                foreach (Position item in player.Items)
                {
                    Brush brush;
                    if (player.Items.First() == item)
                    {
                        brush = Brushes.Red;
                    }
                    else
                    {
                        brush = Brushes.Black;
                    }
                    graphics.FillRectangle(brush, item.X, item.Y, 20, 20);
                    lblPlayer1Name.Location = new Point((player.X - lblPlayer1Name.Width / 2 + 10), player.Y - 20);
                }
            }
            
            
        }
        private void FrmGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameState != GameState.Running)
            {
                return;
            }
            Directions newDirection = e.KeyCode switch
            {
                Keys.Right when playerDirection != Directions.Left && !hasMoved => Directions.Right,
                Keys.Left when playerDirection != Directions.Right && !hasMoved => Directions.Left,
                Keys.Up when playerDirection != Directions.Down && !hasMoved  => Directions.Up,
                Keys.Down when playerDirection != Directions.Up && !hasMoved  => Directions.Down,
                _ => playerDirection
            };
            hasMoved = true;
            playerDirection = newDirection;
        }
        private void FrmGame_Load(object sender, EventArgs e)
        {
            eventHandlers.GameOver += GameOver;
        }
        private void BtnDifficulty_Click(object sender, EventArgs e)
        {
            GameSettings.Difficulty = GameSettings.Difficulty switch
            {
                Difficulty.Easy => Difficulty.Medium,
                Difficulty.Medium => Difficulty.Hard,
                Difficulty.Hard => Difficulty.Easy,
                _ => Difficulty.Easy
            };
            btnDifficulty.Text = GameSettings.Difficulty switch
            {
                Difficulty.Easy => "The Last Serpent",
                Difficulty.Medium => "Reincarnation of Vasuki",
                Difficulty.Hard => "Serpentine Sovereign Apex",
                _ => "The Last Serpent"
            };
            btnDifficulty.ForeColor = GameSettings.Difficulty switch
            {
                Difficulty.Easy => Color.LimeGreen,
                Difficulty.Medium => Color.Orange,
                Difficulty.Hard => Color.Red,
                _ => Color.Green
            };
        }
        private void GameOver(object sender, EventArgs e)
        {
            gameTimer.Enabled = false;
            gameState = GameState.GameOver;
            canvas.Invalidate();
            DrawGameOver();
        }
        private void DrawGameOver()
        {
            Label lblGameOver = new();
            lblGameOver.Text = "Game Over";
            lblGameOver.AutoSize = true;
            lblGameOver.Font = new Font("Segoe UI", 36, FontStyle.Bold);
            lblGameOver.ForeColor = Color.Red;
            lblGameOver.BackColor = Color.Transparent;
            lblGameOver.Location = new Point((lblGameOver.Width), (lblGameOver.Height + 20));

            canvas.Controls.Add(lblGameOver);

            Label lblScore = new();
            lblScore.Text = $"Score";
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            lblScore.ForeColor = Color.Red;
            lblScore.BackColor = Color.Transparent;
            lblScore.Location = new Point(canvas.Width / 2 - lblScore.Width / 2, lblScore.Height + 20 + lblGameOver.Height);
            canvas.Controls.Add(lblScore);

            Label lblScoreValues = new();
            lblScoreValues.Text = $"Player 1: {player.Score} - Player 2: {player.Score}";
            lblScoreValues.AutoSize = true;
            lblScoreValues.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            lblScoreValues.ForeColor = Color.Red;
            lblScoreValues.BackColor = Color.Transparent;
            lblGameOver.TextAlign = ContentAlignment.MiddleCenter;
            lblGameOver.Anchor = AnchorStyles.Top;
            lblScoreValues.Location = new Point(canvas.Width/2 - lblScoreValues.Width * 2, lblScore.Height + 10 + lblGameOver.Height + lblScore.Height);
            canvas.Controls.Add(lblScoreValues);
        }
    }
}
