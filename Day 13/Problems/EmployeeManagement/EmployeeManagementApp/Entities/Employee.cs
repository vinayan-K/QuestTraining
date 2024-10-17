using EmployeeManagementApp.Entities.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Entities
{
    internal class Employee
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName}{LastName}";
        public string Email { get; set; }
        public EmploymentType EmploymentType { get; set; }

        public override string ToString()
        {
            return $"{FullName} , {Email} , {Id}";
        }
    }
}
