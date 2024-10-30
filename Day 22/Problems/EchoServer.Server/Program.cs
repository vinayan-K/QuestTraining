using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EchoServer.Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var ip = IPAddress.Parse("127.0.0.1");
            //var port = 8000;

            //var listener = new TcpListener(ip, port);
            //listener.Start();
            //Console.WriteLine($"App is listening on {ip}:{port} ");

            //Socket socket = listener.AcceptSocket();
            //Console.WriteLine("Client connected");

            //while (true)
            //{

            //    var buffer = new byte[1024];
            //    var dataLength = socket.Receive(buffer);
            //    string message = Encoding.ASCII.GetString(buffer, 0, dataLength);
            //    Console.WriteLine($"Message received: {message}");


            //    byte[] responseData = Encoding.ASCII.GetBytes(message);
            //    socket.Send(responseData);
            //}


            var serverBuilder = new ServerBuilder();
            serverBuilder.Run(res => Console.WriteLine(res));
            serverBuilder.Shutdown();

        }
    }
}
