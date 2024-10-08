using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = new Dictionary<string, List<int>>();
            while (true)
            {
                Console.WriteLine($"Enter the ID or q to exit ");
                var option = Console.ReadLine();
                if (option == "q")
                {
                    break;
                }
                if (d.ContainsKey(option))
                {
                    Console.WriteLine("This ID already exists. Please enter a unique ID.");
                    continue;
                }
                var marks = new List<int>();
                for (int i = 0; i <= 3; i++)
                {
                    Console.WriteLine($"Enter the mark {i + 1}");
                    var mark = int.Parse(Console.ReadLine());
                    marks.Add(mark);
                }
                d.Add(option, marks);

                foreach (var item in d)
                {
                    Console.WriteLine($"{item.Key}:{string.Join(",", item.Value)}");
                }
            }
            Console.WriteLine("Enter the id for search : ");
            var searchid = Console.ReadLine();
            if (d.ContainsKey(searchid))
            {
                Console.WriteLine("marks : ");
                var marks = d[searchid];
                Console.WriteLine($"Found entry for ID {searchid}: {string.Join(", ", marks)}");
            }

        }
    }
}
