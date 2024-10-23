using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Out
{
    internal class Program
    {
        static void DoThis(out int num)
        {
            num = 0;
        }
        static bool TrimToFiveChars(ref string data)
        {
            if (data.Length > 5)
            {
                data = data.Substring(0, 5);
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            //int number = 1;
            DoThis(out int number);
            Console.WriteLine(number);

            var text = "Old text";
            if (TrimToFiveChars(ref text))
            {
                Console.WriteLine(text + "....");
            }
            else
            {
                Console.WriteLine(text);
            }
        }
    }
}
