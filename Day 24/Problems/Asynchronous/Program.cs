using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
    internal class Program
    {
        static async Task<int> Multiply(int number)
        {
            await Task.Delay(1000);
            return number * 2;
        }
        public static async Task Main()
        {
            var tasks = new List<Task<int>>();
            tasks.Add(Task.Run(() => Multiply(2)));
            tasks.Add(Task.Run(() => Multiply(3)));
            tasks.Add(Task.Run(() => Multiply(4)));
            tasks.Add(Task.Run(() => Multiply(5)));

            int[] results = await Task.WhenAll(tasks);
            Console.WriteLine(string.Join(",",results));
        }
    }
}
