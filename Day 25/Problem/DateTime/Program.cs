using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dt = DateTime.Now;
            Console.WriteLine($"Day: {dt.Day}");
            Console.WriteLine($"Month: {dt.Month}");
            Console.WriteLine($"Year: {dt.Year}");

            Console.WriteLine($"Hour: {dt.Hour}");
            Console.WriteLine($"Minute: {dt.Minute}");
            Console.WriteLine($"Second: {dt.Second}");
            Console.WriteLine($"Millisecond: {dt.Millisecond}");


            Console.WriteLine($"Standard Output:{dt}");
            Console.WriteLine(dt.ToString("dd-MM-yy hh-mm-ss"));
            Console.WriteLine(dt.ToString("MM-dd-yy hh-mm-ss"));
            Console.WriteLine(dt.ToString("dd/MM/yy hh-mm-ss"));
            Console.WriteLine(dt.ToString("dd-MM-yy hh-mm-ss"));


            var utc = DateTime.UtcNow;
            Console.WriteLine(utc);
            var dateTimeAfterFiveDay = DateTime.Now.AddDays(5);
            Console.WriteLine(dateTimeAfterFiveDay);
            var dateTimeaYesterDay = DateTime.Now.AddDays(-1);
            Console.WriteLine(dateTimeaYesterDay);
            var date = dt.AddMonths(1);
            Console.WriteLine(date);
            var dateTimeAfterTwoHourThirtyMinute = DateTime.Now.AddHours(2).AddMinutes(30);
            Console.WriteLine(dateTimeAfterTwoHourThirtyMinute);
            var newDt = new DateTime(2024, 12, 8);
            Console.WriteLine(newDt);





        }
    }
}
