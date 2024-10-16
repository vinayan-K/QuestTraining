using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.Name = "John Doe";
            p1.Email = "person1@example.com";
            var addresslines = new List<Addressline>
            {
                new Addressline{ Addresstype = "Home",AddressLine1 = "123 Main St",AddressLine2 = " Springfield",Pincode = "670307"},
                new Addressline{ Addresstype = "Office",AddressLine1 = "456 Elm St",AddressLine2 = " Metropolis",Pincode = "670308"},
            };
            p1.Addresslines = addresslines;
            Console.WriteLine(p1);
            
        }
    }
}
