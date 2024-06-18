using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace QuantumSerpent
{
    public delegate void UpdateGameDrawing();
    public class SerpentServer
    {
        private readonly int port;
        private readonly int playerCount;
        private readonly int initLength;
        private readonly int interval;
        private readonly string serverName;
        private List<Player> playerList;
        private List<Food> foodList;
        public SerpentServer(int port, int playerCount, int initLength, int interval, string serverName, List<Player> playerList, List<Food> foodList)
        {
            this.port = port;
            this.playerCount = playerCount;
            this.initLength = initLength;
            this.interval = interval;
            this.serverName = serverName;
            this.playerList = playerList;
            this.foodList = foodList;
        }

        private Dictionary<TcpClient, Player> clientPlayers = [];
        private TcpListener server;
        private List<TcpClient> clients = [];
        private static int PlayerInstCount { get; set; } = 1;
        private static int MaxWidth { get; set; }
        private static int MaxHeight { get; set; }
        public UpdateGameDrawing Drawgame { get; set; }
        public void StartServer(int maxWidth, int maxHeight)
        {
            MaxWidth = maxWidth;
            MaxHeight = maxHeight;

            server = new TcpListener(IPAddress.Any, port);
            server.Start();

            BroadcastGameState(playerList, foodList);

            //MessageBox.Show($"Server '{serverName}' started on port {port} (IP: " + GetIPHelper.GetIP() + ")");

            Task.Run(async () =>
            {
                while (true)
                {
                    TcpClient client = await server.AcceptTcpClientAsync();
                    clients.Add(client);
                    //MessageBox.Show($"Client connected: {((IPEndPoint)client.Client.RemoteEndPoint).Address}");
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
                    //MessageBox.Show($"Received from client: {data}");
                    
                    HandleData(data, client);

                    // Process data received from client (assuming it's player direction for now)
                    // Here, you would validate the direction and update game state accordingly
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception handling client: {ex.Message}");
            }
        }
        public void HandleData(string data, TcpClient client)
        {
            string dataNoDenom = data[5..];
            if (data.StartsWith("#0;&/"))
            {
                (int x, int y) = GetSpawnPositions();
                var player = Player.Create(dataNoDenom, x, y, initLength, Directions.Up);
                playerList.Add(player);
                clientPlayers.Add(client, player);
                Drawgame();
            }
            else if(data.StartsWith("#1;&/"))
            {
                Directions newDirection;

                // Determine the new direction based on the received string
                newDirection = dataNoDenom switch
                {
                    "Up" => Directions.Up,
                    "Down" => Directions.Down,
                    "Left" => Directions.Left,
                    "Right" => Directions.Right,
                    _ => throw new InvalidOperationException("Invalid direction received")
                };

                // Get the current direction of the player
                Directions currentDirection = clientPlayers[client].PlayerDirection;

                // Prevent 180-degree turns by disallowing reverse directions
                if ((currentDirection == Directions.Up && newDirection == Directions.Down) ||
                    (currentDirection == Directions.Down && newDirection == Directions.Up) ||
                    (currentDirection == Directions.Left && newDirection == Directions.Right) ||
                    (currentDirection == Directions.Right && newDirection == Directions.Left))
                {
                }
                else
                {
                    clientPlayers[client].PlayerDirection = newDirection;
                }

            }
        }
        public (int x, int y) GetSpawnPositions()
        {
            // Ensure we do not exceed the player count
            if (PlayerInstCount > playerCount)
            {
                throw new InvalidOperationException("Maximum number of players reached.");
            }

            int x, y;
            int ring1 = 2, ring2 = 4;

            List<(int, int)> positions = new()
            {
                (ring1, MaxHeight - ring1),
                (MaxWidth - ring1, MaxHeight - ring1),
                (MaxWidth - ring1, ring1),
                (ring1, ring1),
                (ring2, MaxHeight - ring2),
                (MaxWidth - ring2, MaxHeight - ring2),
                (MaxWidth - ring2, ring2),
                (ring2, ring2)
            };
            

            foreach (var position in positions)
            {
                if (IsPositionValid(position, playerList, foodList))
                {
                    PlayerInstCount++;
                    return position;
                }
            }

            throw new InvalidOperationException("No valid spawn position found.");
        }

            private bool IsPositionValid((int x, int y) pos, List<Player> playerList, List<Food> foodList)
            {
                // Check against existing players
                foreach (var player in playerList)
                {
                    if (player.X == pos.x && player.Y == pos.y)
                    {
                        return false;
                    }
                }

                // Check against existing food
                foreach (var food in foodList)
                {
                    if (food.Position.X == pos.x && food.Position.Y == pos.y)
                    {
                        return false;
                    }
                }

                return true;
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