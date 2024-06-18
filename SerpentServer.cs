using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

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

        public void StartServer()
        {
            server = new TcpListener(IPAddress.Any, port);
            server.Start();

            Console.WriteLine($"Server '{serverName}' started on port {port}");

            Task.Run(async () =>
            {
                while (true)
                {
                    TcpClient client = await server.AcceptTcpClientAsync();
                    clients.Add(client);
                    Console.WriteLine($"Client connected: {((IPEndPoint)client.Client.RemoteEndPoint).Address}");

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

                    // Broadcast updated game state to all clients
                    BroadcastGameState(data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception handling client: {ex.Message}");
            }
        }

        private void BroadcastGameState(string gameState)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(gameState);

            foreach (TcpClient client in clients)
            {
                NetworkStream stream = client.GetStream();
                stream.Write(buffer, 0, buffer.Length);
            }
        }

        public void StopServer()
        {
            server.Stop();
        }
    }
}
