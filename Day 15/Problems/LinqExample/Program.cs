using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 8, 2, 3, 7, 9, 2, 3, 8, -9, 5, -8, 10, -3};
            var res = data
                     .Skip(3)
                     .Take(5)
                     .Where(x => x % 2 == 0)
                     .Sum();
            Console.WriteLine(string.Join(",",res));
            var negative = data.Where(i => i < 0);
            Console.WriteLine(string.Join(",", negative));
            var firstItem = data.First();
            Console.WriteLine(string.Join(",", firstItem));
            var firstOrDefault = data.FirstOrDefault();
            Console.WriteLine(string.Join(",", firstOrDefault));
            var lastItem = data.Last();
            Console.WriteLine(lastItem);
            var asc = data.OrderBy(X => X);
            Console.WriteLine(string.Join(",", asc));
            var desc = data.OrderByDescending(X => X);
            Console.WriteLine(string.Join(",", desc));
            var min = data.Min();
            Console.WriteLine( min);
            var max = data.Max();
            Console.WriteLine( max);
            var count = data.Count();
            Console.WriteLine(count);
            var even = data.TakeWhile(x => x % 2 == 0);
            Console.WriteLine(string.Join(",", even));
            var odd = data.SkipWhile(x => x % 2 == 0);
            Console.WriteLine(string.Join(",", odd));
            var distinct = data.Distinct();
            Console.WriteLine(string.Join(",", distinct));
        }
    }
}
