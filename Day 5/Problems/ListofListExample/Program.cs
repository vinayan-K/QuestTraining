using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {                     
            var data = new List<List<int>>();
           
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter the marks of student{i+1} : ");
                var datainner = new List<int>();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Mark {j+1} : ");
                    datainner.Add(int.Parse(Console.ReadLine()));
                }
                data.Add(datainner);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"The marks of student{i + 1} is : ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Mark {j + 1} : ");
                    Console.Write(data[i][j] + ",");
                }
                Console.WriteLine();
            }
        }
    }
}
