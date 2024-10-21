using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var strings = new List<string>() { "apple", "orange", "banana", "cherry", "avocado" };
            var sortedStrings = strings.FirstOrDefault(x => x.StartsWith("b"));

            var result = sortedStrings.Any() ? sortedStrings : null;

            
            if (result == null)
            {
                Console.WriteLine("No fruits starting with 'a'");
            }
            else
            {
                foreach (var fruit in result)
                {
                    Console.WriteLine(fruit);
                }
            }           
        }
    }
}
