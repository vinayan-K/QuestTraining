using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = new List<string>() { "Alice, Bob, Jane" };
            var job = new List<string>() { "Farmer, Doctor, Engineer" };
            var res = name.Zip(job, (Names, Jobs) => { return new { Names, Jobs }; });
                      
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }

    
}
