using System;

namespace Question16
{
    class Employee
    {
        private double  Salary { get; set; }
        public Employee(double salary) 
        {
            Salary = salary;
        }
        public virtual void CalculateBonus() => Console.WriteLine($"Bonus = {Salary * 10 / 100}");
    }
}
