using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 3, 5, 6, 6, 8, 9, 10, 11, 18, 13, 19 };
            var count = numbers.Count(x => x > 10);
            Console.WriteLine(count);
        }
    }
}
