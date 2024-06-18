using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace QuantumSerpent
{
    public class SerpentServer
    {
        private readonly int port;
        private readonly int playerCount;
        private readonly int initLength;
        private readonly int interval;
        private readonly string serverName;

        private TcpListener server;
        private List<TcpClient> clients = new List<TcpClient>();

        public SerpentServer(int port, int playerCount, int initLength, int interval, string serverName)
        {
            this.port = port;
            this.playerCount = playerCount;
            this.initLength = initLength;
            this.interval = interval;
            this.serverName = serverName;
        }

        public void StartServer(List<Player> playerList ,List<Food> foodList)
        {
            server = new TcpListener(IPAddress.Any, port);
            server.Start();

            MessageBox.Show($"Server '{serverName}' started on port {port} (IP: " + GetIPHelper.GetIP() + ")");

            Task.Run(async () =>
            {
                while (true)
                {
                    TcpClient client = await server.AcceptTcpClientAsync();
                    clients.Add(client);
                    MessageBox.Show($"Client connected: {((IPEndPoint)client.Client.RemoteEndPoint).Address}");
                    BroadcastGameState(playerList, foodList);
                    HandleClient(client);
                }
            });
        }

        private async void HandleClient(TcpClient client)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[2048];
                int bytesRead;

                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    Console.WriteLine($"Received from client: {data}");

                    // Process data received from client (assuming it's player direction for now)
                    // Here, you would validate the direction and update game state accordingly
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception handling client: {ex.Message}");
            }
        }

        public void BroadcastGameState(List<Player> playerList, List<Food> foodList)
        {
            string gameStateJson = GetJson(playerList, foodList);
            // Assuming tcpClients is a list of TcpClient instances representing each player's connection
            foreach (var tcpClient in clients)
            {
                // Get the network stream for sending data
                NetworkStream stream = tcpClient.GetStream();

                // Convert JSON string to bytes
                byte[] data = Encoding.UTF8.GetBytes(gameStateJson);

                // Send data over the network stream
                stream.Write(data, 0, data.Length);
            }

        }

        public void StopServer()
        {
            server.Stop();
        }

        private string GetJson(List<Player> playerList, List<Food> foodList)
        {
            // Serialize playerList and foodList to JSON strings
            string playersJson = JsonConvert.SerializeObject(playerList);
            string foodJson = JsonConvert.SerializeObject(foodList);

            // Combine into a single JSON object or array if needed
            return JsonConvert.SerializeObject(new { Players = playersJson, Food = foodJson });
        }
        public static void ParseJson(string jsonString, List<Player> playerList, List<Food> foodList)
        {
            // Deserialize the JSON string to an anonymous object
            var HelpMe = JsonConvert.DeserializeObject<HelpMe>(jsonString);

            // Deserialize the individual JSON strings back into their respective lists
            playerList = JsonConvert.DeserializeObject<List<Player>>(HelpMe.Players);
            foodList = JsonConvert.DeserializeObject<List<Food>>(HelpMe.Food);
        }


    }
    internal class HelpMe
    {
        public string Players { get; set; }
        public string Food { get; set; }
    }
}
