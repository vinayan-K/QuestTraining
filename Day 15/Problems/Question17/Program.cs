using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question17
{
    class Employee
    {
        public string Name { get; set; }
        public int DepartmentId { get; set; }
    }
    class Department
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<Department>()
            {
                new Department{Id = 1, Name = "Dept 1"},
                 new Department{Id = 2, Name = "Dept 2"},
            };
            var employees = new List<Employee>()
            {
                new Employee{Name = "John" , DepartmentId = 1},
                new Employee{Name = "Mary" , DepartmentId = 2},
                new Employee{Name = "Jane" , DepartmentId = 1},
            };
            var empWithDepts = employees
                .Join(
                    departments,
                    e => e.DepartmentId,
                    d => d.Id,
                    (e, d) => new
                    {
                        EmployeeName = e.Name,
                        DepartmentName = d.Name,
                    }
                    );
            foreach (var item in empWithDepts)
            {
                Console.WriteLine(item.EmployeeName+" - " + item.DepartmentName);
            }
        }
    }
}
