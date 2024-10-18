namespace Question1
{
    class Rectangle : Shape
    {
        private double length, width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public override double Area() => length * width;

    }

}
