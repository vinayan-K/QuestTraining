using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student()
            {
                Name = "student1",
                Age = 15,
            };
            var s2 = new Student()
            {
                Name = "student2",
                Age = 18,
            };
            Student[] students = new Student[2];
            students[0] = s1;   
            students[1] = s2;
            Console.WriteLine(students[0].Name);
            foreach (var student in students)
            {
                Console.WriteLine($"Name :{student.Name} Age :{student.Age}");
            }
        }
    }
}
