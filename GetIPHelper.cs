using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QuantumSerpent
{
    public class GetIPHelper
    {
        public static string GetIP()
        {
            string ipAddress = "";

            // Get the host name of the machine
            string hostName = Dns.GetHostName();

            // Get the IP addresses associated with the host name
            IPAddress[] addresses = Dns.GetHostAddresses(hostName);

            // Find the first IPv4 address
            foreach (IPAddress address in addresses)
            {
                if (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    ipAddress = address.ToString();
                    break;
                }
            }

            return ipAddress;
        }
    }
}

