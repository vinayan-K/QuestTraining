using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            var evenNumbers = numbers.Where(x => x % 2 == 0);
            Console.WriteLine(string.Join(",",evenNumbers));
        }
    }
}
