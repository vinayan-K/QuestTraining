using StudentManagementApp.Entities.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp.Entities
{
    internal class Student
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName}{LastName}";
        public string Email { get; set; }
        public CourseType CourseType { get; set; }

        public override string ToString()
        {
            return $"{FullName} , {Email} , {Id}";
        }
    }
}
