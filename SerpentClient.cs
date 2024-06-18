using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace QuantumSerpent
{
    public class SerpentClient(int port, string ip)
    {
        public int Port { get; private set; } = port;
        public string IP { get; private set; } = ip;
        private TcpClient client;
        public Player ClientPlayer { get; set; }

        public void Connect()
        {
            client = new TcpClient(IP, Port);
        }

        public void SendData(string data)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            stream.Write(buffer, 0, buffer.Length);
        }

        public string ReceiveData()
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[2048];
            int i = stream.Read(buffer, 0, buffer.Length);
            return Encoding.ASCII.GetString(buffer, 0, i);
        }

        public void Disconnect()
        {
            client.Close();
        }
    }
}
