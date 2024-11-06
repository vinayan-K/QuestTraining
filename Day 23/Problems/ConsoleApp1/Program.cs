using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyClass
    {
        public string Name { get; private set; }
        public void SetValue()
        {
            Name = "New Name";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyClass() 
            {
                //Name = "New"
            };
            Console.WriteLine(obj.Name);
        }
    }
}
