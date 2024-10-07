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
            int[] array = { 1, 2, 3, 4 };

            if (array.Length % 2 != 0)
            {
                var firstHalf = array.Take(array.Length / 2).Reverse().ToArray();
                var secondHalf = array.Skip(array.Length / 2 + 1).Reverse().ToArray();
                firstHalf.CopyTo(array, 0);
                secondHalf.CopyTo(array, array.Length / 2 + 1);
                Console.WriteLine(string.Join(" ", array));
            }
            else
            {
                var firstHalf = array.Take(array.Length / 2).Reverse().ToArray();
                var secondHalf = array.Skip(array.Length / 2).Reverse().ToArray();
                firstHalf.CopyTo(array, 0);
                secondHalf.CopyTo(array, array.Length / 2 );
                Console.WriteLine(string.Join(" ", array));
            }
        }
    }
}