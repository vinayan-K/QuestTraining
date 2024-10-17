using StudentManagementApp.Entities;
using StudentManagementApp.Entities.Type;
using StudentManagementApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp
{
    internal class StudentManager
    {
        private readonly IStorageService _storageService;
        public StudentManager(IStorageService storageService)
        {
            _storageService = storageService;
        }
        public void Add()
        {
            var student = new Student();

            student.Id = Guid.NewGuid().ToString();

            Console.Write("Enter the first name: ");
            student.FirstName = Console.ReadLine();

            Console.Write("Enter the last name: ");
            student.LastName = Console.ReadLine();

            Console.Write("Enter the email: ");
            student.Email = Console.ReadLine();

            Console.Write("Enter the employment type : 1.Fulltime 2.Parttime ");
            var courseType = Console.ReadLine();
            student.CourseType = courseType == "1" ? CourseType.FullTime : CourseType.PartTime;

            _storageService.Save(student);

        }
        public void SearchById()
        {
            Console.WriteLine("Enter the id for search:");
            var id = Console.ReadLine();
            var student = _storageService.SearchById(id);
            if (student == null)
            {
                Console.WriteLine("Employee Not Found");
            }
            Console.WriteLine(student);

        }
        public void SearchByName()
        {
            Console.WriteLine("Enter the name for search:");
            var name = Console.ReadLine();
            var student = _storageService.SearchByName(name);
            if (student == null)
            {
                Console.WriteLine("Employee Not Found");
            }
            Console.WriteLine(student);

        }
        public void Remove()
        {
            Console.WriteLine("Enter the id for remove");
            var id = Console.ReadLine();
            _storageService.Delete(id);
        }
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Search student by id");
                Console.WriteLine("3. Search student by name");
                Console.WriteLine("4. Delete student");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        SearchById();
                        break;
                    case "3":
                        SearchByName();
                        break;
                    case "4":
                        Remove();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
