using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    internal class Program
    {
        delegate void Operation(int a, int b);
        public static void Add(int a, int b) => Console.WriteLine( a + b);
        public static void Multiply(int a, int b) => Console.WriteLine(a * b);
        static void Main(string[] args)
        {
            Operation operation = Add;
            operation += Multiply;
            operation(5,6);
        }
    }
}
