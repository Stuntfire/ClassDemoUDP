using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPSender
{
    internal class Sender
    {
        private readonly int PORT;
        public Sender(int port)
        {
            PORT = port;
        }

        public void Start()
        {
            using (UdpClient client = new UdpClient())
            {
                IPEndPoint ModtagerEP = new IPEndPoint(IPAddress.Loopback, PORT);
                string str = "Peter";
                byte[] buffer = Encoding.ASCII.GetBytes(str);

                client.Send(buffer, buffer.Length, ModtagerEP);


                //modtager
                IPEndPoint AfsenderEP = new IPEndPoint(IPAddress.Any, 0);
                byte[] receive = client.Receive(ref AfsenderEP);

                Console.WriteLine("Modtaget fra " + AfsenderEP.Address + " " + AfsenderEP.Port);
                String mstr = Encoding.ASCII.GetString(receive);
                Console.WriteLine("Modtaget \n" + mstr);


            }

        }
    }
}