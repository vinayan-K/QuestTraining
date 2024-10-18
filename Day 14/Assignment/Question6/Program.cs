﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    internal class Program
    {
        static void DisplayMessage(string message) => Console.WriteLine(message);
        delegate void PrintMessage(string message);
        static void Main(string[] args)
        {
            PrintMessage message = DisplayMessage;
            message("Hello");
        }
    }
}
