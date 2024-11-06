using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hellow World";
            char[] chars = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                chars[i] = str[str.Length - 1 - i];
            }
            Console.WriteLine(string.Join("",chars));
        }
    }
}
