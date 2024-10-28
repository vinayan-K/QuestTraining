using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "This is a     string";
            string[] data = s.Split(' ');
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
    }
}
