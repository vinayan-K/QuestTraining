using EmployeeManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Services
{
    internal interface IStorageService
    {
        void Save(Employee employee);

        Employee SearchById(string id);
        Employee SearchByName(string name);
        void Delete(string id);
    }
}
