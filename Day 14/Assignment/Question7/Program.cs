using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Func<int, int, int> Add = (a, b) => a + b; ;
            Console.WriteLine("Enter First Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum:{Add(num1,num2)}");

        }
    }
}
