using EmployeeManagementApp.Entities.Type;
using EmployeeManagementApp.Entities;
using EmployeeManagementApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp
{
    internal class EmployeeManager
    {
        private readonly IStorageService _storageService;
        public EmployeeManager(IStorageService storageService)
        {
            _storageService = storageService;
        }
        public void Add()
        {
            var employee = new Employee();

            employee.Id = Guid.NewGuid().ToString();

            Console.Write("Enter the first name: ");
            employee.FirstName = Console.ReadLine();

            Console.Write("Enter the last name: ");
            employee.LastName = Console.ReadLine();

            Console.Write("Enter the email: ");
            employee.Email = Console.ReadLine();

            Console.Write("Enter the employment type : 1.Fulltime 2.Contract ");
            var employmentType = Console.ReadLine();
            employee.EmploymentType = employmentType == "1" ? EmploymentType.FullTime : EmploymentType.Contract;

            _storageService.Save(employee);

        }
        public void SearchById()
        {
            Console.WriteLine("Enter the id for search:");
            var id = Console.ReadLine();
            var employee = _storageService.SearchById(id);
            if (employee == null)
            {
                Console.WriteLine("Employee Not Found");
            }
            Console.WriteLine(employee);

        }
        public void SearchByName()
        {
            Console.WriteLine("Enter the name for search:");
            var name = Console.ReadLine();
            var employee = _storageService.SearchByName(name);
            if (employee == null)
            {
                Console.WriteLine("Employee Not Found");
            }
            Console.WriteLine(employee);

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
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Search Employee by id");
                Console.WriteLine("3. Search Employee by name");
                Console.WriteLine("4. Delete Employee");

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
