using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question 1 //

            //Console.WriteLine("Enter the number of rows :");
            //int row = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= row; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}


            // Question 2 //    

            //Console.WriteLine("Enter the number of rows :");
            //int row = int.Parse(Console.ReadLine());
            //int index = 1;
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write($"{index,3}");
            //        index++;
            //    }
            //    Console.WriteLine();
            //}

            // Question 3 //

            Console.WriteLine("Enter the number of rows :");
            int row = int.Parse(Console.ReadLine());
            for (int i = 0; i < row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
