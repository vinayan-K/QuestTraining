using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    internal class Program
    {
        //static void Greet() => Console.WriteLine("Hellow");
        //static void GreetMessage(string message) => Console.WriteLine(message);
        //static void Add(int a,int b) => Console.WriteLine(a + b);
        //static int GetNumber() => 10;
        //static int AddNumbers(int a,int b) => a+b;
        
        //static bool IsEven(int a) => a % 2 == 0;


        static void GetDataBasedonConditon(int[] data, Predicate<int> predicate)
        {
            var result = new List<int>();
            foreach (var item in data)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            Console.WriteLine(string.Join(",",result));
        }

        static void Main(string[] args)
        {
            //Action g = Greet;
            //Action <string> g2 = GreetMessage;
            //Action<int ,int> g3 = Add;
            //g();
            //g2("Hellow");
            //g3(3, 4);

            //Func<int, int, int> g4 = AddNumbers;
            //Func<int> g5 = GetNumber;
            //var res = g4(1,2);
            //var n = g5();
            //Console.WriteLine(res);
            //Console.WriteLine(n);

            //Predicate<int> b = IsEven;
            //var result = b(10);
            //Console.WriteLine(result);
            
            var data = new int[] { 1, 2, 3, 4 , 5 , 6 , 7 , 8 , 9 , 10 , -5 ,-8 , -6 };
            GetDataBasedonConditon(data, x => x % 2 == 0);
            GetDataBasedonConditon(data, y => y < 0);
            GetDataBasedonConditon(data, a =>  a < 8 && a > 0);
           
        }
    }
}
