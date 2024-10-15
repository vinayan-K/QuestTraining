using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneExample
{
    class SmartPhone
    {
        public string Name;
        public string Manufacturer;
        public List<int> MemoryVarients;
        public void Display() 
        {
            Console.WriteLine("Name : " +Name);
            Console.WriteLine("Manufaturer : " + Manufacturer);
            Console.WriteLine("Memory Varients : " + string.Join(",",MemoryVarients));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartPhone phone1 = new SmartPhone();
            phone1.Name = "S23";
            phone1.Manufacturer = "Samsung";
            phone1.MemoryVarients = new List<int>() { 128, 256, 512 };
            phone1.Display();


        }
    }
}
