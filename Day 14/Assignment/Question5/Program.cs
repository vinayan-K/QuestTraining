using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    internal class Program
    {
        static void Add(int a,int b) => Console.WriteLine(a +b);
        static void Multiply(int a,int b) => Console.WriteLine(a *b);
        delegate void MathDelegate (int a,int b);
        static void Main(string[] args)
        {
            MathDelegate Operation = Add;            
            Operation += Multiply;
            Operation(3, 5);

        }
    }
}
