using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Program
    {
        class SchoolStudent : Istudent
        {
            public string Name { get; set; }
            public string SchoolName = "School A";
            public void Display()
            {
                Console.WriteLine($"Name : {Name}, SchoolName: {SchoolName}");
            }
        }
        class CollegeStudent : Istudent
        {
            public string Name { get; set; }
            public string CollegeName = "College X";
            public void Display()
            {
                Console.WriteLine($"Name : {Name}, CollegeName: {CollegeName}");
            }
        }
        static void Main(string[] args)
        {
            var students = new List<Istudent>
            {
                new SchoolStudent{Name = "John"},
                new CollegeStudent{Name = "Jane"},
            };
            foreach (var student in students)
            {
                student.Display(); 
            }
        }
    }
}
