using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> length = x => x.Length;
            Console.WriteLine("Enter the string :");
            var str = Console.ReadLine();
            Console.WriteLine($"Length :{length(str)}");
        }
    }
}
