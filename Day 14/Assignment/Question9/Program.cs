using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question9
{
    internal class Program
    {
        static void PrintWelcomemessage(string message) => Console.WriteLine(message);
        static void Main(string[] args)
        {
            Action<string> action = PrintWelcomemessage;
            action("Welcome to c#");
        }
    }
}
