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
            try
            {
                client = new TcpClient(IP, Port);
            }
            catch { }
        }

        public void SendData(string data)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            stream.Write(buffer, 0, buffer.Length);
        }

        public string ReceiveData()
        {
            try
            {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[2048];
            int i = stream.Read(buffer, 0, buffer.Length);
            return Encoding.ASCII.GetString(buffer, 0, i);
            }
            catch (Exception e)
            {
                if(e is System.IO.IOException)
                {
                    MessageBox.Show("Server forced the connection to close. Disconnecting.");
                    this.Disconnect();
                }
            }
            return "";
        }

        public void Disconnect()
        {
            client.Close();
        }
    }
}
