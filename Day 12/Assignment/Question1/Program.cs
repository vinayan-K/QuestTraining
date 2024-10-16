using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sManager = new StudentManager();

            while (true)
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Search");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        var student = GetstudentData();
                        sManager.Add(student);
                        break;
                    case "2":
                        Console.Write("Enter the id to search: ");
                        var idToSearch = Console.ReadLine();
                        sManager.Search(idToSearch);
                        break;
                    case "3":
                        Console.Write("Enter the id to update: ");
                        var idToUpdate = Console.ReadLine();
                        var updateStudent = GetstudentData();
                        sManager.Update(updateStudent, idToUpdate);
                        break;

                    case "4":
                        Console.Write("Enter the id to delete :");
                        var studentIdDelete = Console.ReadLine();
                        sManager.Delete(studentIdDelete);
                        break;
                }
            }
        }

        private static Student GetstudentData()
        {
            Student student = new Student();

            Console.Write("Enter the Id: ");
            student.id = Console.ReadLine();

            Console.Write("Enter the student name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter the grade: ");
            student.Grade = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter subject name: ");
                string subjectName = Console.ReadLine();

                Console.Write($"Enter marks for {subjectName}: ");
                int markObtained = int.Parse(Console.ReadLine());

                Console.Write($"Enter maximum marks for {subjectName}: ");
                int maxMarks = int.Parse(Console.ReadLine());

                student.TotalMarks.Add(new Mark
                {
                    SubjectName = subjectName,
                    MarkObtained = markObtained,
                    MaximumMark = maxMarks
                });

            }
            return student;
        }
    }
    
}
