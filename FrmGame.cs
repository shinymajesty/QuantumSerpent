namespace QuantumSerpent
{
    public partial class FrmGame : Form
    {
        Directions playerDirection = Directions.Right;
        readonly static Player player1 = new(40, 40, 10);
        readonly static Player player2 = new(460, 460, 10);
        readonly static List<Player> playerList = [];
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
            player1.Move(playerDirection);
            ValidatePlayerPosition();
            canvas.Invalidate(); // Force redraw
            hasMoved = false;
        }
        private void ValidatePlayerPosition()
        {
            if (player1.X < 0 || player1.X >= canvas.Width || player1.Y < 0 || player1.Y >= canvas.Height)
            {
                eventHandlers.TriggerGameOver();
            }
            foreach (Position pos in player1.Items.Skip(1))
            {
                if (pos.X == player1.X && pos.Y == player1.Y)
                {
                    eventHandlers.TriggerGameOver();
                    player1.State = PlayerState.Dead;
                }
            }
        }
        private void SetupPlayerNames()
        {
            foreach (Player player in playerList)
            {
                Label lblPlayerName = new() {
                Text = player.Name,
                Width = 0,
                Height = 0,
                AutoSize = true,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                BackColor = Color.Transparent
                };
                lblPlayerName.TextAlign = ContentAlignment.MiddleLeft;
                canvas.Controls.Add(lblPlayerName);
                lblPlayerName.BringToFront();
            }
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            string player1_Name = txtName1.Text;
            string player2_Name = txtName2.Text;
            GameSettings.Bot1 = chkBot1.Checked;
            GameSettings.Bot2 = chkBot2.Checked;

            if (player1_Name != "")
            {
                playerList.Add(new Player(40,40,3) { Name = player1_Name});
            }
            if (player1_Name != "")
            {
                playerList.Add(new Player(460, 460, 3) { Name = player2_Name});
            }


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
                foreach(Player player in playerList)
                {
                    if (player.State == PlayerState.Alive)
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
                            if (canvas.Controls.Find("lblPlayer1Name", true).FirstOrDefault() is Label lblName)
                            {
                                lblName.Location = new Point((player.X - lblName.Width / 2 + 10), player.Y - 20);
                            }
                        }
                    }
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
            lblScoreValues.Text = $"Player 1: {player1.Score} - Player 2: {player1.Score}";
            lblScoreValues.AutoSize = true;
            lblScoreValues.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            lblScoreValues.ForeColor = Color.Red;
            lblScoreValues.BackColor = Color.Transparent;
            lblGameOver.TextAlign = ContentAlignment.MiddleCenter;
            lblGameOver.Anchor = AnchorStyles.Top;
            lblScoreValues.Location = new Point(canvas.Width/2 - lblScoreValues.Width * 2, lblScore.Height + 10 + lblGameOver.Height + lblScore.Height);
            canvas.Controls.Add(lblScoreValues);

            canvas.BackgroundImage = null;
        }
    }
}
