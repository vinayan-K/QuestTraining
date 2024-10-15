using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class student
    {
        public string Name;
        public int Mark1;
        public int Mark2;
        public int Mark3;

        public void TotalMark()
        {
            Console.WriteLine($"Total Mark is:{Mark1 + Mark2 + Mark3}");
        }

        public void AverageMarks()
        {
            Console.WriteLine($"Average Mark is : {(Mark1 + Mark2 + Mark3)/3}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.Name = "John";
            s.Mark1 = 1;
            s.Mark2 = 2;
            s.Mark3 = 3;
            s.AverageMarks();
            s.TotalMark();

            student s1 = new student();
            s1.Name = "Jane";
            s1.Mark1 = 35;
            s1.Mark2 = 25;
            s1.Mark3 = 40;
            s1.AverageMarks();
            s1.TotalMark();
        }
    }
}
