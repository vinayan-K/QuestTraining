using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            var square = numbers.Select(x => x * x).ToArray();
            foreach (var x in square)
            {
                Console.WriteLine(x);
            }
        }
    }
}
