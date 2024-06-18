using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuantumSerpent
{
    public partial class MultiplayerGame : Form
    {
        private readonly List<Food> foodList = new List<Food>();
        private readonly List<Player> playerList = new List<Player>();
        private readonly SerpentServer server;
        private readonly string playerName;
        private readonly int playerCount;
        private readonly int initLength;
        private readonly int interval;
        private GameState gameState = GameState.Paused;
        Form formCreator;
        private int MaxWidth => canvas.Width/GameSettings.Size;
        private int MaxHeight => canvas.Height/GameSettings.Size;

        public MultiplayerGame(Form formCreator, string playerName, int playerCount, int initLength, int interval)
        {
            InitializeComponent();
            this.playerName = playerName;
            this.playerCount = playerCount;
            this.initLength = initLength;
            this.interval = interval;
            this.formCreator = formCreator;

            playerList.Add(Player.Create(MaxWidth, MaxHeight, playerName));
            GameEngine.GenerateFood(playerList, foodList, MaxWidth, MaxHeight);

            server = new SerpentServer(9876, playerCount, initLength, interval, playerName);
            server.StartServer();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (gameState != GameState.Running)
            {
                return;
            }

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
            canvas.Invalidate();
            RedrawScoreboard();
        }

        private void RedrawScoreboard()
        {
            DrawUtils.UpdateScoreboard(tblScore, playerList);
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            // Update any additional labels or UI elements as needed
        }

        private void GameOverFunction(Player player)
        {
            gameState = GameState.GameOver;
            SwitchControls();
            btnStopGame.Enabled = true;
        }

        private void SwitchControls()
        {
            btnShutDown.Enabled = !btnShutDown.Enabled;
            btnStopGame.Enabled = !btnStopGame.Enabled;
            gameTimer.Enabled = !gameTimer.Enabled;
            btnStart.Enabled = !btnStart.Enabled;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SwitchControls();
            gameState = GameState.Running;
        }

        private void btnStopGame_Click(object sender, EventArgs e)
        {
            Player.Reset();
            playerList.Clear();
            playerList.Add(Player.Create(MaxWidth, MaxHeight, playerName));
            foodList.Clear();
            canvas.Controls.Clear();
            canvas.Invalidate();
            gameState = GameState.Paused;
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            server.StopServer();
            this.Close();
        }

        private void MultiplayerGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.StopServer();
            formCreator.Show();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            DrawUtils.DrawGame(e.Graphics, GameSettings.Size, gameState, playerList, foodList, canvas);
        }

        private void MultiplayerGame_KeyDown(object sender, KeyEventArgs e)
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
    }
}
