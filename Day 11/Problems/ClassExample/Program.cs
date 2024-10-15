using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class student
    {
        public string Name;
        public void DisplayName()
        {
            Console.WriteLine(Name.ToUpper());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.Name = "John";
            s.DisplayName();

            student s1 = new student();
            s1.Name = "Jane";
            s1.DisplayName();
        }
    }
}
