using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public Student(Student original)
        {
            Name = original.Name;
            Id = original.Id;
        }
        public override string ToString() => $"{Name} - {Id}";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Bob",2);
            var copyStudent = new Student(student);
            Console.WriteLine(student);
            Console.WriteLine(copyStudent);

        }
    }
}
