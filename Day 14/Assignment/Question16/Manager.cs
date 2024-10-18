using System;

namespace Question16
{
    class Manager : Employee
    {
        private double Salary { get; set; }
        public Manager (double salary) : base(salary) 
        {
            Salary = salary;
        }
        public override void CalculateBonus() => Console.WriteLine($"Bonus = {Salary * 20 / 100}");
    }
}
