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

        public void StartServer(List<Player> playerList, List<Food> foodList)
        {
            server = new TcpListener(IPAddress.Any, port);
            server.Start();

            BroadcastGameState(playerList, foodList);

            MessageBox.Show($"Server '{serverName}' started on port {port} (IP: " + GetIPHelper.GetIP() + ")");

            Task.Run(async () =>
            {
                while (true)
                {
                    TcpClient client = await server.AcceptTcpClientAsync();
                    clients.Add(client);
                    MessageBox.Show($"Client connected: {((IPEndPoint)client.Client.RemoteEndPoint).Address}");
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
            // Combine playerList and foodList into a single anonymous object and serialize to JSON
            var combinedObject = new { Players = playerList, Food = foodList };
            return JsonConvert.SerializeObject(combinedObject);
        }

        public static void ParseJson(string jsonString, List<Player> playerList, List<Food> foodList)
        {
            // Deserialize the JSON string into a strong type with matching structure
            var combinedObject = JsonConvert.DeserializeObject<CombinedObject>(jsonString);

            // Assign the deserialized lists to the passed-in lists
            playerList.Clear();
            playerList.AddRange(combinedObject!.Players!);

            foodList.Clear();
            foodList.AddRange(combinedObject!.Food!);
        }

        // Define a class to represent the combined JSON object structure


    }
    internal class CombinedObject
    {
        public List<Player>? Players { get; set; }
        public List<Food>? Food { get; set; }
    }
}