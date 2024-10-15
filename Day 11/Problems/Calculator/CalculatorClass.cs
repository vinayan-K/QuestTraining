using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class CalculatorClass
    {
        private int Num1;
        private int Num2;

        public void Add() => Console.WriteLine($"The sum is :{Num1 + Num2}");

        public void Subtract() => Console.WriteLine($"The Difference is :{Num1 - Num2}");

        public void Multiply() => Console.WriteLine($"The answer is :{Num1 * Num2}");

        public void Division() => Console.WriteLine($"The answer is :{Num1 / Num2}");


        public void Run()
        {
            Console.Write("Enter the firt number:");
            Num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number :");
            Num2= int.Parse(Console.ReadLine());
            Add();  
            Subtract();
            Multiply(); 
            Division(); 
        }
    }
}
