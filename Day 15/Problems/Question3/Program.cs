using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 10, 3, 4, 9, 19, 7, 8, 5, 2, 11, 6, 13, 14 };
            var desc = numbers.OrderByDescending(X => X);
            Console.WriteLine(string.Join(",",desc));
        }
    }
}
