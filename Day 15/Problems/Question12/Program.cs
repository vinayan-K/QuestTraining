using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 3, 39, 50, 55, 60, -9, -8 };
            var positive = data.All(x => x > 0);
            Console.WriteLine(string.Join(",",positive));
        }
    }
}
