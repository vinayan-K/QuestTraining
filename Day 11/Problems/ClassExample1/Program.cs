using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample1
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public int Salary;

        public void TotalSalary()
        {
            Console.WriteLine($"Total Salary :{Salary * 12}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.FirstName = "John";
            employee1.LastName = "Doe";
            employee1.Salary = 10_000;
            employee1.TotalSalary();

            Employee employee2 = new Employee();
            employee2.FirstName = "Jane";
            employee2.LastName = "Doe";
            employee2.Salary = 15_000;
            employee2.TotalSalary();
        }
    }
}
