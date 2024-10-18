using Question1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(10);
            var rectangle = new Rectangle(8, 2);
            Console.WriteLine($"Circle Area= {circle.Area()}");
            Console.WriteLine($"Rectangle Area = {rectangle.Area()}");

        }
    }

}
