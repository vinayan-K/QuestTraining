using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            var s1 = new Student()
            {
                Name = "student1",
                Mark1 = 10,
                Mark2 = 20,
            };
            var s2 = new Student()
            {
                Name = "student2",
                Mark1 = 30,
                Mark2 = 20,
            };
            var s3 = new Student()
            {
                Name = "student3",
                Mark1 = 15,  
                Mark2 = 20,
            };
            Student[] students = new Student[3];
            students[0] = s1;   
            students[1] = s2;
            students[2] = s3;
            foreach (var student in students)
            {
                sum = sum + student.Mark1 + student.Mark2;
            }
            Console.WriteLine("Sum of Marks: "+sum);
        }
    }
}
