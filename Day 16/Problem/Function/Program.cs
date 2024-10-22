using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class Program
    {
        static int Calc(bool doAddition, int x, int y)
        {
            return doAddition ? x + y : x - y;
        }
        static void Main(string[] args)
        {
            var res = Calc(true, 2, 3);
            Console.WriteLine(res);
        }
    }
}
