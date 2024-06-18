using System;
using System.Windows.Forms;

namespace QuantumSerpent
{
    public partial class SerpentClientGame : Form
    {
        private readonly SerpentClient client;
        private string playerName;

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

                    // Process received game state (e.g., update player positions, redraw game)
                    // Example: UpdatePlayerPositions(gameState);
                    Console.WriteLine($"Received game state: {gameState}");
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
    }
}
