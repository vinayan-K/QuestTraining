using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            var square = numbers.Where(x => x%2 == 0).Select(x => x * x);
            foreach (var x in square)
            {
                Console.WriteLine(x);
            }
        }
    }
}
