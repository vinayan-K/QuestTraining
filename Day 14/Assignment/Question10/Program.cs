using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> action = (a, b) => Console.WriteLine($"Sum = {a + b}");
            Console.WriteLine("Enter the first number :");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number :");
            int num2 = int.Parse(Console.ReadLine());
            action(num1, num2);
        }
    }
}
