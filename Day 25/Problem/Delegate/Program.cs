using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {

        public static int Calculate(int a, int b, Func<int, int, int> operation) => operation(a, b);

        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;

            Console.WriteLine("Addition: " + Calculate(a, b, (x, y) => x + y));
            Console.WriteLine("Multiply: " + Calculate(a, b, (x, y) => x * y));
            Console.WriteLine("Sub : " + Calculate(a, b, (x, y) => x - y));
            Console.WriteLine("Division: " + Calculate(a, b, (x, y) => x / y));
        }
    }

}
