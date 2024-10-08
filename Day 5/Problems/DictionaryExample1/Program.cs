using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Dictionary<string,string> d = new Dictionary<string,string>();
            //var d = new Dictionary<string, string>();
            //d.Add("First Name", "John");
            //d.Add("Last Name", "Doe");
            //Console.WriteLine(d["First Name"]);
            //d["First Name"] = "Jane";
            //Console.WriteLine(d["First Name"]);
            //d.Remove("Last Name");
            //if (d.ContainsKey("Age"))
            //{
            //    Console.WriteLine(d["Age"]);
            //}
            //else
            //{
            //    Console.WriteLine("NOT FOUND");
            //}
            //foreach (var item in d)
            //{
            //    Console.WriteLine($"{item:Key}:{item:value}");
            //}

            var d = new Dictionary<string, List<int>>();
            while (true)
            {
                Console.WriteLine($"Enter the ID or q to exit ");
                var option = Console.ReadLine();
                if (option == "q")
                {
                    break;
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
        }
    }
}
