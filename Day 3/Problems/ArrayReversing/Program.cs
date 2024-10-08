using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReversing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Printing array in reverse order //   
            int[] array = new int[6];
            int n = array.Length - 1;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter the numbers {i} : ");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i + n] + " ");
                n = n - 2;
            }
        }
    }
}
