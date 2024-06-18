using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuantumSerpent
{
    public partial class SerpentClientGame : Form
    {
        private SerpentClient client;
        private string playerName;
        private List<Player> playerList = new List<Player>(); // Initialize playerList
        private List<Food> foodList = new List<Food>(); // Initialize foodList
        private readonly string IP;
        private readonly int Port;
        private (int MaxWidth, int MaxHeight) MaxSize;

        public SerpentClientGame(string serverIP, int serverPort)
        {
            InitializeComponent();
            client = new SerpentClient(serverPort, serverIP);
            client.Connect();
            IP = serverIP;
            Port = serverPort;

            // Start listening to server updates asynchronously
            StartReceivingUpdates();
        }

        private async void StartReceivingUpdates()
        {
            try
            {
                await Task.Run(() =>
                {
                    while (true)
                    {
                        string gameState = client.ReceiveData();
                        SerpentServer.ParseJson(gameState, playerList, foodList, ref MaxSize);

                        // Update the UI on the UI thread
                        try
                        {
                            canvas.Invoke((Action)(() =>
                            {
                                GameSettings.Size = canvas.Width / MaxSize.MaxWidth;
                                canvas.Size = new System.Drawing.Size(MaxSize.MaxWidth * GameSettings.Size, MaxSize.MaxHeight * GameSettings.Size);
                                canvas.Controls.Clear();
                                canvas.Invalidate();
                            }));
                        }
                        catch { }
                        try
                        {
                            // Enable buttons and text box if playerList is empty
                            if (playerList.Count == 0)
                            {
                                Invoke((Action)(() =>
                                {
                                    btnDC.Enabled = true;
                                    btnJoin.Enabled = true;
                                    txtName.Enabled = true;
                                }));

                                // Close the form
                                Invoke((Action)(() =>
                                {
                                    Close();
                                }));
                            }
                        }
                        catch { }
                    }
                });
            }
            catch (Exception e)
            {
                MessageBox.Show("Server forced the connection to close. Disconnecting.");
                client.Disconnect();
                Close();
            }
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
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void btnDC_Click(object sender, EventArgs e)
        {
            client.Disconnect();
            Close(); // Close the form
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
