using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat();    
            cat.Speak();

            var dog = new Dog();
            dog.Speak();
        }
    }
}
