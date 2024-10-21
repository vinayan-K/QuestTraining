using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 3, 5, 6, 6, 8, 9, 10, 11, 10, 13, 10 };
            var sortedList = numbers.Distinct();
            Console.WriteLine(string .Join(",",sortedList));
        }
    }
}
