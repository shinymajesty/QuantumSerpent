using System.Numerics;
using System.Windows.Forms;

namespace QuantumSerpent
{
    public partial class SinglePlayer : Form
    {
        private MainMenu mainMenu;
        static List<Player> playerList = [];
        List<Food> foodList = [];
        GameState gameState = GameState.Paused;
        int MaxHeight => canvas.Height / GameSettings.Size;
        int MaxWidth => canvas.Width / GameSettings.Size;
        public SinglePlayer(MainMenu formCreator)
        {
            InitializeComponent();
            mainMenu = formCreator;
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if(gameState != GameState.Running)
            {
                return;
            }
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

            GameEngine.CheckCollision(playerList, foodList, MaxWidth, MaxHeight, GameOverFunction);
            
            

            gameTimer.Interval = (int)GameEngine.CalculateInterval(playerList);
            canvas.Controls.Clear();
            canvas.Invalidate(); // Force redraw
            RedrawScoreboard();
        }
        private void GameOverFunction(Player player)
        {
            gameState = GameState.GameOver;
            lblMSG.Visible = true;
            lblMSG.Text = $"{player.Name} has lost!";
            ShowHighScoreMenu(player);
            SwitchControls();

        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            GameSettings.Bot1 = chkBot1.Checked;
            GameSettings.Bot2 = chkBot2.Checked;
            foodList = [];
            lblMSG.Visible = false;
            Player.Reset();

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

            SwitchControls();
            gameState = GameState.Running;
            this.Focus();
            GameEngine.GenerateFood(playerList, foodList, MaxWidth, MaxHeight);
        }
        private void SwitchControls()
        {
            txtName1.Enabled = !txtName1.Enabled;
            chkBot1.Enabled = !chkBot1.Enabled;
            chkBot2.Enabled = !chkBot2.Enabled;
            btnDifficulty.Enabled = !btnDifficulty.Enabled;
            btnSpawn.Enabled = !btnSpawn.Enabled;
            btnBack.Enabled = !btnBack.Enabled;
            BtnReset.Enabled = !BtnReset.Enabled;


            gameTimer.Enabled = !gameTimer.Enabled;
            btnStart.Enabled = !btnStart.Enabled;
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {

            // Reset all parameters
            playerList.Clear();
            foodList.Clear();
            gameState = GameState.Paused;
            lblMSG.Visible = false;
            Player.Reset();

            // Reset choices
            txtName1.Enabled = true;
            chkBot1.Enabled = true;
            chkBot2.Enabled = true;
            btnDifficulty.Enabled = true;
            btnSpawn.Enabled = true;
            btnBack.Enabled = true;
            BtnReset.Enabled = true;
            btnStart.Enabled = true;

            

            // Clear canvas
            canvas.Controls.Clear();
            canvas.Invalidate();
        }
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            DrawUtils.DrawGame(e.Graphics, GameSettings.Size, gameState, playerList, foodList, canvas);
            //          Graphics graphics| int scale        | gameState| IEnumerable<Player>| IEnumerable<Food>| canvas //so many parameters, let's pray the game still runs ;D
            //After excessive testing, the game still runs. PRAISE THE LORD!
            //Since we will need a similar method for the multiplayer mode of the game, I decided to create a new class called DrawUtils.cs
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
                    if (player.HandleKey(e.KeyCode))
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
        private void BtnAddPlayer_Click(object sender, EventArgs e)//Event handler for the add player button
        {
            //Factory -> Spawns Players
            try
            {
                Player player = Player.Create(MaxWidth, MaxHeight, txtName1.Text);
                playerList.Add(player);
                RedrawScoreboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            txtName1.Text = "";

            canvas.Invalidate();
        }
        private void BtnBack_Click(object sender, EventArgs e)//Event handler for the back button
        {
            mainMenu.Show();
            this.Close();
        }
        private void SinglePlayer_FormClosed(object sender, FormClosedEventArgs e)//No need to move this method, as it is an event handler for the form!
        {
            if (mainMenu.Visible == false) mainMenu.Close();
        }
        public ((IEnumerable<Position>, IEnumerable<Food>), (int, int)) GetWorldInfo()//No need to move this method, as the multiplayer mode will not have any AI players!
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
        private void RedrawScoreboard()// Moved to DrawUtils.cs!
        {
            DrawUtils.UpdateScoreboard(scoreboardTBL, playerList);
            //Same as DrawGame, we will move this method to DrawUtils.cs
        } 
        private void ShowHighScoreMenu(Player player) //No need to move this method, as the multiplayer unlike the arcade mode, will not have a highscore system!
        {
            if(player is AIPlayer)
            {
                return;
            }



            // Create the high score entry
            HighScore newScore = new HighScore(player.Name, player.Score);

            // Retrieve all existing high scores
            FileDAO fileDAO = new FileDAO("highscores.txt");
            List<HighScore> existingHighScores = fileDAO.GetAllHighScores();

            // Check if the new score is a high score
            bool isNewHighScore = IsNewHighScore(existingHighScores, newScore);

            if (isNewHighScore)
            {
                // Show high score menu only if it's a new high score
                HighScoreMenu highScoreMenu = new HighScoreMenu(newScore);
                highScoreMenu.ShowDialog();
            }
        }
        private bool IsNewHighScore(List<HighScore> existingHighScores, HighScore newScore)
        {
            // Check if the new score is higher than any existing score for the same player
            foreach (var score in existingHighScores)
            {
                if (score.PlayerName == newScore.PlayerName && newScore.Score > score.Score)
                {
                    return true;
                }
            }

            // If no existing score for the player or new score is not higher, return false
            return existingHighScores.All(score => score.PlayerName != newScore.PlayerName);
        }



    }
}
