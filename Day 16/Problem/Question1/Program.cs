using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Circle : IShape
    {
        public double Radius { get; set; }

        public double GetArea() => Math.PI * Math.Pow(Radius, 2);
        public double GetPerimeter() => 2 * Math.PI * Radius;
    }
    class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double GetArea() => Length * Width;
        public double GetPerimeter() => 2 * (Length + Width);
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var shape = new List<IShape>()
            {
                new Rectangle{Length = 10, Width = 5 },
                new Circle{ Radius = 10,},
            };
            foreach (var item in shape)
            {
                Console.WriteLine($"Area = {item.GetArea()}, Perimeter = {item.GetPerimeter()}");
            }

        }
    }
}
