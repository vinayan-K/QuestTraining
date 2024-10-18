using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.MakeSound();

            var animal = new Animal();
            animal.MakeSound();
        }
    }
}
