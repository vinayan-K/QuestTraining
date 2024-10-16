using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poroperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new Student
            {
                Name = "Test",
                Age = 500
            };
            Console.WriteLine(s.Name);
            Console.WriteLine(s.Age);
        }
    }
}
