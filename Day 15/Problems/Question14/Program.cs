using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<double>() {1.2, 3.4, 5.3, 6.8, 4.2};
            var avg = numbers.Average();
            Console.WriteLine(avg);
        }
    }
}
