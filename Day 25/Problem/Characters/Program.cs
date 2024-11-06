using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string : ");
            var str = Console.ReadLine();
            var result = str.ToLower()
            .GroupBy(x => x)
            .OrderBy(x => x.Count());
            var leastRepeated = result.Last();
            var mostRepeated = result.First();
            Console.WriteLine($"LeastRepeated : {leastRepeated.Key} - {leastRepeated.Count()}");
            Console.WriteLine($"MoststRepeated : {mostRepeated.Key}- {mostRepeated.Count()}");

        }
    }
}
