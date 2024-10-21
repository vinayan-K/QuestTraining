using ExtensionMethods.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 8;

            Console.WriteLine(num1.IsEven());
            Console.WriteLine(num2.IsEven());
            Console.WriteLine(num1.IsOdd());
            Console.WriteLine(num2.IsOdd());
        }
    }
}
