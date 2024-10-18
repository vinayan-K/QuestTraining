using System;

namespace Question1
{
    class Circle : Shape
    {
        private double Radius { get; set; }
        public Circle(double r)
        {
            Radius = r;
        }
        public override double Area() => Math.PI * Math.Pow(Radius,2);
    }

}
