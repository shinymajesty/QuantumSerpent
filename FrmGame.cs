using System.Numerics;

namespace QuantumSerpent
{
    public partial class FrmGame : Form
    {
        readonly static Player[] playerList = new Player[4];
        GameState gameState = GameState.Paused;
        int MaxHeight => canvas.Height / GameSettings.Size;
        int MaxWidth => canvas.Width / GameSettings.Size;

        public FrmGame()
        {
            InitializeComponent();
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Game loop
            foreach (var player in playerList)
            {
                if (player == null)
                {
                    continue;
                }
                player.Move(player.PlayerDirection);
                player.HasMoved = false;
            }
            ValidatePlayerPosition();
            canvas.Controls.Clear();
            canvas.Invalidate(); // Force redraw

        }
        private void ValidatePlayerPosition()
        {
            foreach (Player player1 in playerList)
            {
                if (player1 == null) continue;
                //Check border collision
                if (player1.X < 0 || player1.X >= MaxWidth || player1.Y < 0 || player1.Y >= MaxHeight)
                {
                    PlayerDied(player1);
                }
                //Check if player has collided with itself
                foreach (var item in player1.Items.Skip(1))
                {
                    if (player1.X == item.X && player1.Y == item.Y)
                    {
                        PlayerDied(player1);
                    }
                }
                //Check if player has collided with another player
                foreach (var player2 in playerList)
                {
                    if (player2 == null) continue;
                    if (player1 == player2)
                    {
                        continue;
                    }
                    foreach (var item in player2.Items)
                    {
                        if (player1.X == item.X && player1.Y == item.Y)
                        {
                            PlayerDied(player1);
                        }
                    }
                }
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
                playerList[0] = (new Player(2, 2, Directions.Right, 3)
                {
                    Name = player1_Name,
                    DownKey = Keys.Down,
                    UpKey = Keys.Up,
                    LeftKey = Keys.Left,
                    RightKey = Keys.Right,
                    HeadColor = Brushes.LimeGreen,
                    BodyColor = Brushes.Black
                });
            }
            if (player2_Name != "")
            {
                playerList[1] = (new Player(23, 2, Directions.Left, 3)
                {
                    Name = player2_Name,
                    DownKey = Keys.S,
                    UpKey = Keys.W,
                    LeftKey = Keys.A,
                    RightKey = Keys.D,
                    HeadColor = Brushes.Red,
                    BodyColor = Brushes.Blue
                });
            }


            txtName1.Enabled = false;
            txtName2.Enabled = false;
            chkBot1.Enabled = false;
            chkBot2.Enabled = false;
            btnDifficulty.Enabled = false;


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
            this.Focus();
        }
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            int scale = GameSettings.Size;
            // Draw the whole game situation
            using var offScreenBitmap = new Bitmap(canvas.Width, canvas.Height);
            using var offScreenGraphics = Graphics.FromImage(offScreenBitmap);
            // Draw the player
            if (gameState == GameState.Running)
            {
                foreach (Player player in playerList)
                {
                    if (player == null) continue;
                    if (player.State == PlayerState.Alive)
                    {
                        foreach (Position item in player.Items)
                        {
                            Brush brush;
                            if (player.Items.First() == item)
                            {
                                brush = player.HeadColor;
                            }
                            else
                            {
                                brush = player.BodyColor;
                            }
                            offScreenGraphics.FillRectangle(brush, item.X * scale, item.Y * scale, scale, scale);
                        }

                        var nameLabel = new Label()
                        {
                            Text = player.Name,
                            AutoSize = true,
                            Width = 0,
                            Height = 0,
                            ForeColor = Color.White,
                            Font = new Font("Segoe UI", 12, FontStyle.Bold),
                            BackColor = Color.Transparent,
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        Size preferredSize = nameLabel.GetPreferredSize(Size.Empty);
                        int newWidth = preferredSize.Width;
                        nameLabel.Location = new Point((player.X * scale - newWidth / 2), (player.Y * scale - 20));
                        canvas.Controls.Add(nameLabel);
                    }
                }
            }

            // Draw the off-screen bitmap to the screen
            e.Graphics.DrawImage(offScreenBitmap, 0, 0);
        }
        private void FrmGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameState != GameState.Running)
            {
                return;
            }
            foreach (var player in playerList)
            {
                player?.HandleKey(e.KeyCode);
            }

        }
        private void FrmGame_Load(object sender, EventArgs e)
        {
            lblMSG.Visible = false;
            //Create Frame Buffer offscreen
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
        private void PlayerDied(Player player)
        {
            canvas.Invalidate();
            player.State = PlayerState.Dead;
            FlashText(player.Name + " died", Color.Red);
        }
        

        private async void FlashText(string text, Color color)
        {
            lblMSG.Text = text;
            lblMSG.ForeColor = color;
            lblMSG.Visible = true;

            await Task.Delay(1000); // Wait for 1 second

            lblMSG.Visible = false;
        }

    }
}
