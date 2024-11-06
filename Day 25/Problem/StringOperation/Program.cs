using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            var str = Console.ReadLine();
            var result = str.ToLower().Split(' ').GroupBy(x => x);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} {item.Count()}");
            }
           
        }
    }
}
