using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Local time 
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            DateTime udt = DateTime.UtcNow;
            Console.WriteLine(udt);

            Console.WriteLine($"Day: {dt.Day}");
            Console.WriteLine($"Month: {dt.Month}");
            Console.WriteLine($"Year: {dt.Year}");

            Console.WriteLine($"Hour: {dt.Hour}");
            Console.WriteLine($"Minute: {dt.Minute}");
            Console.WriteLine($"Second: {dt.Second}");
            Console.WriteLine($"Millisecond: {dt.Millisecond}");

            var tenDaysFromNow = dt.AddDays(10);
            Console.WriteLine(tenDaysFromNow);

            var tenDaysTenHoursFromNow = dt.AddDays(10).AddHours(10);
            Console.WriteLine(tenDaysTenHoursFromNow);

            Console.WriteLine("-------");
            Console.WriteLine($"Standard Output:{dt}");
            Console.WriteLine(dt.ToString("dd-MM-yy hh-mm-ss"));
            Console.WriteLine(dt.ToString("MM-dd-yy hh-mm-ss"));
            Console.WriteLine(dt.ToString("dd/MM/yy hh-mm-ss"));
            Console.WriteLine(dt.ToString("dd-MM-yy hh-mm-ss"));

            var myDt = new DateTime(2024, 10, 7, 12, 50, 59);
            Console.WriteLine(myDt);
        }
    }
}
