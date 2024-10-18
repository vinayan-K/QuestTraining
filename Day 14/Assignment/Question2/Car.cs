using System;

namespace Question2
{
    class Car : Vehicle
    {
        private int Speed { get; set; }
        public Car (int speed)
        {
            Speed = speed;
        }
        public override void Drive() => Console.WriteLine($"The car has a speed of {Speed} Km/hr");
    }
}
