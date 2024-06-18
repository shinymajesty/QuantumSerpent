using System;
using System.Windows.Forms;

namespace QuantumSerpent
{
    public partial class SerpentClientGame : Form
    {
        private readonly SerpentClient client;
        private string playerName;
        private List<Player> playerList = [];
        private List<Food> foodList = [];
        public SerpentClientGame(string playerName, string serverIP, int serverPort)
        {
            InitializeComponent();
            this.playerName = playerName;
            client = new SerpentClient(serverPort, serverIP);
            client.Connect();

            // Start listening to server updates asynchronously
            StartReceivingUpdates();
        }

        private async void StartReceivingUpdates()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    string gameState = client.ReceiveData();
                    SerpentServer.ParseJson(gameState, playerList, foodList);
                    canvas.Invalidate();
                    // Process received game state (e.g., update player positions, redraw game)
                    // Example: UpdatePlayerPositions(gameState);

                }
            });
        }

        private void SendDirection(string direction)
        {
            client.SendData(direction);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            // Translate KeyDown events into direction changes and send to server
            string direction = TranslateKeyCodeToDirection(e.KeyCode);
            SendDirection(direction);
        }

        private string TranslateKeyCodeToDirection(Keys keyCode)
        {
            switch (keyCode)
            {
                case Keys.Up:
                    return "Up";
                case Keys.Down:
                    return "Down";
                case Keys.Left:
                    return "Left";
                case Keys.Right:
                    return "Right";
                default:
                    return string.Empty;
            }
        }

        private void SerpentClientGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Disconnect();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            DrawUtils.DrawGame(e.Graphics, GameSettings.Size, GameState.Running, playerList, foodList, canvas);
        }
    }
}
