using EmployeeManagementApp.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Services
{
    internal class JsonFileStorage : IStorageService
    {
        private readonly string _storagedirectory;
        public JsonFileStorage()
        {
            var documentspath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            _storagedirectory = Path.Combine(documentspath, "EmployeeManagementApp", "JsonFiles");
            Directory.CreateDirectory(_storagedirectory);
        }

        public void Delete(string id)
        {
            var filePath = Path.Combine(_storagedirectory, $"{id}.json");
            File.Delete(filePath);
            Console.WriteLine("Deleted successfully");
        }

        public Employee SearchById(string id)
        {
            var files = Directory.GetFiles(_storagedirectory);
            foreach (var file in files)
            {
                var fileContentJson = File.ReadAllText(file);
                var employee = JsonConvert.DeserializeObject<Employee>(fileContentJson);

                var employeeId = employee.Id.ToString();

                if (employeeId.Contains(id))
                {
                    return employee;
                }

            }
            return null;

        }

        public Employee SearchByName(string name)
        {
            var files = Directory.GetFiles(_storagedirectory);
            foreach (var file in files)
            {
                var fileContantJson = File.ReadAllText(file);
                var employee = JsonConvert.DeserializeObject<Employee>(fileContantJson);
                var employeeName = employee.FullName.ToLowerInvariant();
                var nameToSearch = name.ToLowerInvariant();

                if (employeeName.Contains(nameToSearch))
                {
                    return employee;
                }

            }
            return null;
        }

        public void Save(Employee employee)
        {
            var jasonText = JsonConvert.SerializeObject(employee);
            var filePath = Path.Combine(_storagedirectory, $"{employee.Id}.json");
            File.WriteAllText(filePath, jasonText);
            Console.WriteLine("Added successfully");
        }
    }
    
    
}
