using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EchoServer.Client
{
    internal class ClientBuilder
    {
        private const string ipAddress = "127.0.0.1";
        private const int port = 8000;
        private TcpClient _client;

        private void Build()
        {
            var ip = IPAddress.Parse(ipAddress);
            _client = new TcpClient();
            _client.Connect(ip, port);
            Console.WriteLine("Connected to server");
        }
        public void Run(Action<string> callback)
        {
            Build();
            while (true)
            {
                //Console.Write("Client : ");
                var message = Console.ReadLine();
                byte[] data = Encoding.ASCII.GetBytes(message);
                _client.GetStream().Write(data, 0, data.Length);
                callback(message);
                Response();
            }
        }
        public void Response()
        {
            byte[] response = new byte[1024];
            var dataLength = _client.GetStream()
                .Read(response, 0, response.Length);
            var responseText = Encoding.ASCII.GetString(response, 0, dataLength);
            Console.WriteLine($"Response : {responseText}");
        }
    }
}
