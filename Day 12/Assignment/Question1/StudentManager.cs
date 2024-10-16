using System;
using System.Collections.Generic;

namespace Question1
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
            foreach (var mark in student.TotalMarks)
            {
                Console.WriteLine(mark);
            }
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
            student.TotalMarks = updateStudent.TotalMarks;
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
