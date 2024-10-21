using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 3, 39, 50, 55, 60};
            var dataGreaterThanFifty = data.Where(x => x > 50);
            Console.WriteLine(string.Join(",", dataGreaterThanFifty));
        }
    }
}
