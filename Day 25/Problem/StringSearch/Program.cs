using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hellow, world! Welcome to the world of C# programming ";
            int count = 0;
            string search = "world";
            string[] strings = str.Split(' ','!','.',',');
            foreach (var item in strings)
            {
                if (item.ToLower() == search.ToLower() )
                {
                    count++;  
                }
            }
            Console.WriteLine($"number of occurrence{search} is {count}");
        }
    }
}
