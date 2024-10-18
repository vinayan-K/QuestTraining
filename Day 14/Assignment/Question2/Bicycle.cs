using System;

namespace Question2
{
    class Bicycle : Vehicle
    {
        private int Speed { get; set; }
        public Bicycle(int speed)
        {
            Speed = speed;
        }
        public override void Drive() => Console.WriteLine($"The bicycle has a speed of {Speed} Km/hr");
    }
}
