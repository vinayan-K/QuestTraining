using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(100);            
            car.Drive();

            var cycle = new Bicycle(10);            
            cycle.Drive();
        }
    }
}
