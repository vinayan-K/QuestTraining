using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter your date of birth (dd-MM-yyy): ");
             string dobInput = Console.ReadLine();
             var dateOfBirth = DateTime.Parse(dobInput);
             int age = DateTime.Now.Year - dateOfBirth.Year;
                if (DateTime.Now < dateOfBirth.AddYears(age))
                {
                   age--;
                }
                Console.WriteLine($"Your age is: {age} years");         
        }
    }
}


