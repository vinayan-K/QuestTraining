﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EchoServer.Server
{
    public class ServerBuilder
    {
        private const string ipAddress = "127.0.0.1";
        private const int port = 8000;
        private TcpListener _listener;
        private Socket _socket;

        private void Build()
        {
            var ip = IPAddress.Parse(ipAddress);
            _listener = new TcpListener(ip, port);
        }

        public void Run(Action<string> callback)
        {
            Build();
            _listener.Start();
            Console.WriteLine($"App is listening 0n {ipAddress}:{port}");

            _socket = _listener.AcceptSocket();
            Console.WriteLine("Client connected");

            while (true)
            {
                var buffer = new byte[1024];
                var dataLength = _socket.Receive(buffer);
                string message = Encoding.ASCII.GetString(buffer, 0, dataLength);
                callback(message);
                SendMessage(message);
            }
        }
        public void SendMessage(string message)
        {
            var data = Encoding.ASCII.GetBytes(message);
            _socket.Send(data);
        }
        public void Shutdown()
        {
            _listener.Stop();
            _socket.Close();
        }
    }
}
