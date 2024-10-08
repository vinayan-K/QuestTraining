using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayofListExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>[] arrayOfLists = new List<int>[3];

            for (int i = 0; i < arrayOfLists.Length; i++)
            {
                arrayOfLists[i] = new List<int>();
            }

            for (int i = 0; i < arrayOfLists.Length; i++)
            {
                Console.WriteLine($"Enter marks for Student {i + 1}:");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Mark {j + 1}: ");
                    int mark = int.Parse(Console.ReadLine());
                    arrayOfLists[i].Add(mark);
                }
            }

            for (int i = 0; i < arrayOfLists.Length; i++)
            {
                Console.WriteLine($"\nMarks for Student {i + 1}: {string.Join(", ", arrayOfLists[i])}");
            }
        }
    }
}
