using System.Numerics;

namespace QuantumSerpent
{
    public partial class SinglePlayer : Form
    {
        private MainMenu mainMenu;
        readonly Random rnd = new();
        readonly static List<Player> playerList = [];
        readonly static List<Label> labelList = [];
        readonly List<Food> foodList = [];
        GameState gameState = GameState.Paused;
        int MaxHeight => canvas.Height / GameSettings.Size;
        int MaxWidth => canvas.Width / GameSettings.Size;
        public Random Rnd => rnd;

        public SinglePlayer(MainMenu formCreator)
        {
            InitializeComponent();
            mainMenu = formCreator;
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
                player.CanMove = true;
            }

            ValidatePlayerPosition();
            if (playerList.Count == 1)
            {
                lblScore.Text = $"Player 1: {playerList[0].Score}";
            }
            if (playerList.Count == 2)
            {
                lblScore.Text = $"Player 1: {playerList[0].Score}";
                lblScore2.Text = $"Player 2: {playerList[1].Score}";
            }

            canvas.Controls.Clear();
            canvas.Invalidate(); // Force redraw

        }
        private void CreateFood()
        {
            int x;
            int y;
            bool success;
            do
            {
                x = Rnd.Next(0, MaxWidth);
                y = Rnd.Next(0, MaxHeight);
                //Check if the food is not on a player
                success = true;

                foreach (var player in playerList)
                {
                    if (player == null) continue;
                    foreach (var item in player.Items)
                    {
                        var newPos = new Position(x, y);
                        if (newPos == item)
                        {
                            success = false;
                            break;
                        }
                    }
                }
                foreach (var food in foodList)
                {
                    var newPos = new Position(x, y);
                    if (newPos == food.Position)
                    {
                        success = false;
                        break;
                    }
                }
            } while (!success);

            if (rnd.Next(0, 100) < 50)
            {
                foodList.Add(new Pepper(new Position(x, y)));
            }
            else
            {
                foodList.Add(new Food(new Position(x, y)));
            }
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

                //Check if player has collided with food
                for (int i = foodList.Count - 1; i >= 0; i--)
                {
                    var food = foodList[i];
                    foreach (var item in playerList)
                    {
                        if (item == null) continue;
                        // Check if player has collided with food
                        var newPos = new Position(item.X, item.Y);
                        if (newPos == food.Position)
                        {
                            item.Eat(food);
                            foodList.Remove(food);
                            if (foodList.Count == 0)
                                CreateFood();
                            break; // not possible that there is more than one food at the same position
                        }
                    }
                }
            }

            for (int i = 0; i < playerList.Count; i++)
            {
                var player = playerList[i];
                if (player == null) continue;
                if (player.State == PlayerState.Dead)
                {
                    playerList.RemoveAt(i);
                    i--; // Decrement i to account for the removed element
                         // Optionally, if you only want to remove one dead player, you can break here
                }
            }
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            GameSettings.Bot1 = chkBot1.Checked;
            GameSettings.Bot2 = chkBot2.Checked;

            txtName1.Enabled = false;
            chkBot1.Enabled = false;
            chkBot2.Enabled = false;
            btnDifficulty.Enabled = false;
            btnSpawn.Enabled = false;
            btnBack.Enabled = false;
            BtnReset.Enabled = false;

            gameTimer.Interval = GameSettings.Difficulty switch
            {
                Difficulty.Easy => 200,
                Difficulty.Medium => 100,
                Difficulty.Hard => 15,
                _ => 200
            };

            if (playerList.Count == 0 && !(GameSettings.Bot1 || GameSettings.Bot2))
            {
                MessageBox.Show("You need to add at least one player to start the game!");
                return;
            }
            if (GameSettings.Bot1)
            {
                AIPlayer bot = new(2, 2, Directions.Right, 3, GetWorldInfo)
                {
                    Name = "Bot 1",
                };
                playerList.Add(bot);
            }
            if (GameSettings.Bot2)
            {
                AIPlayer bot = new(MaxWidth - 2, MaxHeight - 2, Directions.Left, 3, GetWorldInfo)
                {
                    Name = "Bot 2",
                };
                playerList.Add(bot);
            }
            gameTimer.Enabled = true;
            btnStart.Enabled = false;
            btnStart.Text = "Reset";
            gameState = GameState.Running;
            this.Focus();
            CreateFood();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            int scale = GameSettings.Size;
            // Draw the whole game situation
            using var offScreenBitmap = new Bitmap(canvas.Width, canvas.Height);
            using var offScreenGraphics = Graphics.FromImage(offScreenBitmap);
            // Draw the player
            if (gameState != GameState.GameOver)
            {
                foreach (Player player in playerList)
                {
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
            // Draw the food
            foreach (Food food in foodList)
            {
                Brush brush = food is Pepper ? Brushes.Red : Brushes.Green;
                offScreenGraphics.FillRectangle(brush, food.Position.X * scale, food.Position.Y * scale, scale, scale);
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
                if (player.CanMove)
                {
                    if(player.HandleKey(e.KeyCode))
                    {
                        player.CanMove = false;
                    }
                }
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
            bool allDead = true;
            foreach (var item in playerList)
            {
                if (item.State == PlayerState.Alive)
                {
                    allDead = false;
                    break;
                }
            }
            if (allDead)
            {
                gameState = GameState.GameOver;
                gameTimer.Enabled = false;
                lblMSG.Visible = true;
                lblMSG.Text = "Game Over!";
                BtnReset.Enabled = true;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            //Factory -> Spawns Players
            try
            {
                Player player = Player.Create(MaxWidth, MaxHeight, txtName1.Text);
                playerList.Add(player);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            txtName1.Text = "";

            canvas.Invalidate();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Hide();
            this.Close();
        }
        private void SinglePlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Visible == false) return;
            mainMenu.Close();
        }
        public ((IEnumerable<Position>, IEnumerable<Food>), (int, int)) GetWorldInfo()
        {
            List<Position> avoid = [];
            List<Food> food = [];
            foreach (var player in playerList)
            {
                if (player == null) continue;
                foreach (var item in player.Items)
                {
                    avoid.Add(item);
                }
            }
            foreach (var item in foodList)
            {
                food.Add(item);
            }
            return ((avoid, food), (MaxWidth, MaxHeight));
        }
       
       
    }
}
