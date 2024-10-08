using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Finding sum of series "1_2_3_1"//

            string pattern = "1_2_3_1";
            int sum = 0;
            int index = 0;
            while (index < pattern.Length)
            {
                sum += int.Parse(pattern[index].ToString());
                index = index + 2;
            }
            Console.WriteLine(sum);
        }
    }
}
