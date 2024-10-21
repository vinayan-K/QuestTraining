using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var strings = new List<string>() { "apple", "orange", "banana", "cherry","avocado" };
            var sortedStrings = strings.Where(x => x.StartsWith("a"));
            foreach (var x in sortedStrings)
            {
                Console.WriteLine(x);
            }

        }
    }
}
