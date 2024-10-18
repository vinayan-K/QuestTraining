using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    abstract class CalculatorBase
    {
        public void Add(int a, int b) => Console.WriteLine(a + b);
        public void Subtract(int a, int b) => Console.WriteLine(a - b);
        public void Multiply(int a, int b) => Console.WriteLine(a * b);
        public virtual void Division(int a, int b) => Console.WriteLine(a / b);
        public abstract void Power(int a, int b);
    }
    class Calculator : CalculatorBase
    {
        public override void Division(int a, int b)
        {
            if (b == 0) 
            {
                Console.WriteLine("Division by zero is not possible");
            }
            base.Division(a, b);
            
        }
        public override void Power(int a, int b) => Console.WriteLine(Math.Pow(a, b));

    }
        internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            calculator.Add(8, 2);
            calculator.Add(8, 3);
            calculator.Subtract(8, 3);
            calculator.Multiply(8, 3);
            calculator.Division(8, 3);
            calculator.Power(6, 2);
            calculator.Division(6, 0);
        }
    }
}
