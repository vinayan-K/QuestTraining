using System;

namespace Question13
{
    class Fan : Appliance
    {
        public override void TurnOn() => Console.WriteLine("The fan is switched on");
    }
}
