using System.Numerics;

namespace QuantumSerpent
{
    public partial class FrmGame : Form
    {
        
        readonly static Player[] playerList = new Player[4];
        GameState gameState = GameState.Paused;

        public FrmGame()
        {
            InitializeComponent();
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Game loop
            foreach (var player in playerList)
            {
                if(player == null)
                {
                    continue;
                }
                player.Move(player.PlayerDirection);
                ValidatePlayerPosition(player);
                player.HasMoved = false;
            }
            
            canvas.Controls.Clear();
            canvas.Invalidate(); // Force redraw
            
        }
        private void ValidatePlayerPosition(Player player)
        {
            int scale = GameSettings.Size;
            if(player.State == PlayerState.Dead)
            {
                return;
            }
            if (player.X < 0 || player.X >= canvas.Width/scale || player.Y < 0 || player.Y >= canvas.Height/scale)
            {
                PlayerDied(player);
            }
            foreach (Position pos in player.Items.Skip(1))
            {
                if (pos.X == player.X && pos.Y == player.Y)
                {
                    PlayerDied(player);
                    player.State = PlayerState.Dead;
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
                playerList[0] = (new Player(2,2,3) { Name = player1_Name, PlayerDirection = Directions.Right});
            }
            if (player2_Name != "")
            {
                playerList[1] = (new Player(23, 2, 3) { Name = player2_Name, PlayerDirection = Directions.Left });
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
            Graphics graphics = e.Graphics;
            // Draw the player
            if (gameState == GameState.Running)
            {
                foreach(Player player in playerList)
                {
                    if (player == null) continue;
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
                            graphics.FillRectangle(brush, item.X*scale, item.Y*scale, scale, scale);
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
                        nameLabel.Location = new Point((player.X * scale - newWidth/2), (player.Y * scale - 20));
                        canvas.Controls.Add(nameLabel);
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

            UpdatePlayerDirection(playerList[0], e, Keys.Right, Keys.Left, Keys.Up, Keys.Down);
            UpdatePlayerDirection(playerList[1], e, Keys.D, Keys.A, Keys.W, Keys.S);
        }



        private void UpdatePlayerDirection(Player player, KeyEventArgs e, Keys rightKey, Keys leftKey, Keys upKey, Keys downKey)
        {
            if (player != null)
            {
                Directions newDirection;

                // Convert key presses to directions
                if (e.KeyCode == rightKey && player.PlayerDirection != Directions.Left)
                {
                    newDirection = Directions.Right;
                }
                else if (e.KeyCode == leftKey && player.PlayerDirection != Directions.Right)
                {
                    newDirection = Directions.Left;
                }
                else if (e.KeyCode == upKey && player.PlayerDirection != Directions.Down)
                {
                    newDirection = Directions.Up;
                }
                else if (e.KeyCode == downKey && player.PlayerDirection != Directions.Up)
                {
                    newDirection = Directions.Down;
                }
                else
                {
                    newDirection = player.PlayerDirection;
                }

                player.PlayerDirection = newDirection;
                player.HasMoved = true;
            }
        }
        private void FrmGame_Load(object sender, EventArgs e)
        {
            lblMSG.Visible = false;
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
        private void FlashText(string text, Color color)
        {
            lblMSG.Text = text;
            lblMSG.ForeColor = color;
            lblMSG.Visible = true;
        }

    }
}
