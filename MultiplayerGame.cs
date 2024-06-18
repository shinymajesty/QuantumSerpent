using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
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
        private Player hostPlayer;
        private GameState gameState = GameState.Paused;
        Form formCreator;
        private int MaxWidth => canvas.Width/GameSettings.Size;
        private int MaxHeight => canvas.Height/GameSettings.Size;

        public MultiplayerGame(Form formCreator, string playerName, int playerCount, int initLength, int interval)
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1000, 600);
            this.playerName = playerName;
            this.playerCount = playerCount;
            this.initLength = initLength;
            this.interval = interval;
            this.formCreator = formCreator;

            hostPlayer = Player.Create(MaxWidth, MaxHeight, playerName);
            playerList.Add(hostPlayer);
            GameEngine.GenerateFood(playerList, foodList, MaxWidth, MaxHeight);

            UpdateLabels();
            formCreator.Hide();
            this.Show();

            server = new SerpentServer(9876, playerCount, initLength, interval, playerName, playerList, foodList);
            server.StartServer(MaxWidth, MaxHeight);
            server.Drawgame = new UpdateGameDrawing(() => canvas.Invalidate());
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
            if (!playerList.Contains(hostPlayer))
                hostPlayer = null;


            gameTimer.Interval = (int)GameEngine.CalculateInterval(playerList);
            canvas.Controls.Clear();
            canvas.Invalidate();
            RedrawScoreboard();
            // Assuming tcpClients is a list of TcpClient instances representing each player's connection
            server.BroadcastGameState(playerList, foodList);

        }

        private void RedrawScoreboard()
        {
            DrawUtils.UpdateScoreboard(tblScore, playerList);
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            lblIP.Text = "Host IP: " + GetIPHelper.GetIP();
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
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void btnStopGame_Click(object sender, EventArgs e)
        {
            server.StopServer();
            server.StartServer(MaxWidth, MaxHeight);
            Player.Reset();
            playerList.Clear();
            hostPlayer = Player.Create(MaxWidth, MaxHeight, playerName);
            playerList.Add(hostPlayer);
            foodList.Clear();
            canvas.Controls.Clear();
            canvas.Invalidate();
            gameState = GameState.Paused;
            GameEngine.GenerateFood(playerList, foodList, MaxWidth, MaxHeight);
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            server.StopServer();
            this.Close();
        }

        private void MultiplayerGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.StopServer();
            if (formCreator.Visible == false)
            {
                Application.Exit();
                return;
            }
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
            if (hostPlayer != null)
            {
                if (hostPlayer.CanMove)
                {
                    if (hostPlayer.HandleKey(e.KeyCode))
                    {
                        hostPlayer.CanMove = false;
                    }
                }
            }
        }
    }
}
