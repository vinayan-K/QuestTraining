using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count ");
            var n =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter numbers ");
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            var sum = n * (n + 1) / 2;
            for (int i = 0; i < n; i++)
            {
                sum -= numbers[i];
            }
            Console.WriteLine($"Missing elemnt {sum}");
        }
    }
}
