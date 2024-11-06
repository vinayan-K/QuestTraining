using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            var num = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (num < 1)
            {
                isPrime = false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
                isPrime = true;
            }
            if (isPrime)
            {
                Console.WriteLine($"{num} is a prime");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime");
            }
        }
    }
}
