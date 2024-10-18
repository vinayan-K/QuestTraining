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
            var calculator = new SimpleCalculator();
            Console.WriteLine($"Sum = {calculator.Add(1, 2)}");
            Console.WriteLine($"Difference = {calculator.Subtract(1, 2)}");
        }
    }
}
