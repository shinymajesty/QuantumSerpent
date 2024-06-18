using System;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace QuantumSerpent
{
    public partial class SerpentClientGame : Form
    {
        private readonly SerpentClient client;
        private string playerName;
        private List<Player> playerList = [];
        private List<Food> foodList = [];
        public SerpentClientGame(string serverIP, int serverPort)
        {
            InitializeComponent();
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

                    // Update the UI on the UI thread
                    canvas.Invoke((Action)(() => //Woho cuz we ain't learn this shit in school :///
                    {
                        canvas.Controls.Clear();
                        canvas.Invalidate();
                    }));
                    if(playerList.Count == 0)
                    {
                        btnDC.Invoke((Action)(() =>
                        {
                            btnDC.Enabled = true;
                        }));
                    }
                }
            });
        }


        private void SendDirection(string direction)
        {
            client.SendData(direction);
        }

        private void SerpentClientGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Disconnect();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            DrawUtils.DrawGame(e.Graphics, GameSettings.Size, GameState.Running, playerList, foodList, canvas);
        }

        private void SerpentClientGame_KeyDown(object sender, KeyEventArgs e)
        {
            Keys keyCode = e.KeyCode;
            if (keyCode == Keys.Up)
            {
                SendDirection("#1;&/Up");
            }
            else if (keyCode == Keys.Down)
            {
                SendDirection("#1;&/Down");
            }
            else if (keyCode == Keys.Left)
            {
                SendDirection("#1;&/Left");
            }
            else if (keyCode == Keys.Right)
            {
                SendDirection("#1;&/Right");
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            playerName = txtName.Text;
            client.SendData("#0;&/" + playerName);
            txtName.Enabled = false;
            btnJoin.Enabled = false;
            btnDC.Enabled = false;
        }
    }
}
