using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    class StudentManager
    {
        private List<Student> Students = new List<Student>();

        public void Add(Student student)
        {
           
            if (GetStudentById(student.id) != null)
            {
                Console.WriteLine("Student already exists");
                return;
            }

            Students.Add(student);
            Console.WriteLine("Added successfully");
        }

        public void Search(string idToSearch)
        {
            var student = GetStudentById(idToSearch);
            if (student == null)
            {
                Console.WriteLine("Student Not Found");
                return;
            }

            Console.WriteLine(student);
        }

        public void Delete(string idToDelete)
        {
            var student = GetStudentById(idToDelete);
            if (student == null)
            {
                Console.WriteLine("Student Not Found");
                return;
            }

            Students.Remove(student);
            Console.WriteLine("Deleted successfully");
            return;
        }

        public void Update(Student updateStudent, string idToUpdate)
        {
            var student = GetStudentById(idToUpdate);
            if (student == null)
            {
                Console.WriteLine("Card Not Found");
                return;
            }

            student.Name = updateStudent.Name;
            student.Grade = updateStudent.Grade;           
            Console.WriteLine("Updated successfully");
        }

      
        private Student GetStudentById(string id)
        {
            foreach (var student in Students)
            {
                if (student.id == id)
                {
                    return student;
                }
            }

            return null;
        }
    }
}

