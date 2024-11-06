using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            var str = Console.ReadLine().ToLower();
            var result = str.Split(' ').Distinct();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
