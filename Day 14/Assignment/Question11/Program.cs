using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Question11
{
    internal class Program
    {
        static void IsEven(int data, Predicate<int> predicate)
        {
            if (predicate(data))
            {
                Console.WriteLine("It is Even");
            }
            else
            {
                Console.WriteLine("It is odd");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value : ");
            var value = int.Parse(Console.ReadLine());
            IsEven(value, x => x % 2 == 0);
        }
    }
}
