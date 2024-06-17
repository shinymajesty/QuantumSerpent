using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace QuantumSerpent
{
    public class SerpentServer(int port, int playerCount, int initLength, int interval, string serverName)
    {
        public int Port { get; private set; } = port;
        public int PlayerCount { get; private set; } = playerCount;
        public int InitLength { get; private set; } = initLength;
        public int Interval { get; private set; } = interval;
        public string ServerName { get; private set; } = serverName;
        private TcpListener server;

        public void StartServer()
        {
            server = new(IPAddress.Any, Port);
            server.Start();

            MessageBox.Show("Server started on port " + Port.ToString());

            byte[] buffer = new byte[2048];
            string data = "";

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                NetworkStream stream = client.GetStream();

                int i;

                while((i = stream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    data = Encoding.ASCII.GetString(buffer, 0, i);
                    MessageBox.Show(data);

                    byte[] msg = Encoding.ASCII.GetBytes(data);

                    stream.Write(msg, 0, msg.Length);
                    MessageBox.Show("Sent: " + data);
                }

                client.Close();
            }

        }

        public void StopServer()
        {
            server.Stop();
        }
    }
}
