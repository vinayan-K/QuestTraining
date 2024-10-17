using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample
{
    class Person
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public string[] PhoneNumber { get; set; }
        public static string CompanyName { get; set; }
        public Person(int phoneNumberCount)
        {
            CreatedAt = DateTime.Now;
            PhoneNumber = new string[phoneNumberCount];
        }
    }
    class Employee
    {
        public string Name { get; set; }

        internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(5);
           
        }
    }
}
