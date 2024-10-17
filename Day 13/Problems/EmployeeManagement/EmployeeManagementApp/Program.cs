using EmployeeManagementApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var storageService = new JsonFileStorage();
            var employeeManager = new EmployeeManager(storageService);
            employeeManager.Run();
        }
    }
}
