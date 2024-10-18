using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question12
{
    internal class Program
    {
        static void FirstElement(string text, Predicate<string> predicate)
        {
            if (predicate(text))
            {
                Console.WriteLine("The text begins with 'A'.");
            }
            else
            {
                Console.WriteLine("The text does not start with 'A'.");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text: ");
            var text = Console.ReadLine().ToLower();
            FirstElement(text, value => value.StartsWith("a"));
        }
    }
}
