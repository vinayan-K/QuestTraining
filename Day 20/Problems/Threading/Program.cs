using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    internal class Program
    {
        static void Action1()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Hellow from Action1");
        }
        static void Action2()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Hellow from Action2");
        }
        static void Main(string[] args)
        {
            var t1 = new Thread(Action1);
            var t2 = new Thread(Action2);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine("Hellow from main");
        }
    }
}
