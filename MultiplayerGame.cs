using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuantumSerpent
{
    public partial class MultiplayerGame : Form
    {
        List<Food> foodList = [];
        GameState gameState = GameState.Paused;
        int MaxHeight => canvas.Height / GameSettings.Size;
        int MaxWidth => canvas.Width / GameSettings.Size;
        SerpentServer server;
        List<Player> playerList = [];
        Form formCreator;
        string name;
        int playerCount;
        int initLength;
        int interval;

        public MultiplayerGame(Form formCreator, string name, int playerCount, int initLength, int interval)
        {
            InitializeComponent();
            playerList.Add(Player.Create(MaxWidth, MaxHeight, "Host"));
            this.Focus();
            this.Show();
            GameEngine.GenerateFood(playerList, foodList, MaxWidth, MaxHeight);
            server = new SerpentServer(9876, playerCount, initLength, interval, name);
            server.StartServer();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (gameState != GameState.Running)
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

        private void RedrawScoreboard()// Moved to DrawUtils.cs!
        {
            DrawUtils.UpdateScoreboard(tblScore, playerList);
            //Same as DrawGame, we will move this method to DrawUtils.cs
            UpdateLabels();
        }
        private void UpdateLabels()// Moved to DrawUtils.cs!
        {


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
            playerList = [Player.Create(MaxWidth, MaxHeight, "Host")];
            foodList = [];
            canvas.Controls.Clear();
            canvas.Invalidate();
            gameState = GameState.Paused;
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            //SerpentServer.StopServer();
            this.Close();
        }



        private void MultiplayerGame_FormClosing(object sender, FormClosingEventArgs e)
        {
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
