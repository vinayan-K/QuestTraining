using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new List<string>() { "apple", "orange", "banana", "cherry", "avocado" };
            var groups = data.GroupBy(x => x.Length);
            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key}  -  {group.Count()}");              
            }
        }
    }
}
