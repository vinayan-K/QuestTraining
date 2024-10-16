using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Students
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            
            return $" Name: {Name} , Email : {Email}";
        }
    }
    class School: Students
    {
        public string SchoolName { get; set; }
        public override string ToString()
        {
            return $" Name: {Name} , Email : {Email}, SchoolName: {SchoolName}";
        }
    }
    class College: Students
    {
        public string CollegeName { get; set; }
        public override string ToString()
        {
            return $" Name: {Name} , Email : {Email},College name: {CollegeName}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new College();
            student.Name = "Student1";
            student.Email = "student1@example.com";
            student.CollegeName = "ABC College";

            var student2 = new School();
            student2.Name = "student2";
            student2.Email = "student2@example.com";
            student2.SchoolName = "RST School";

            Console.WriteLine(student);
            Console.WriteLine(student2);
        }
    }
}
