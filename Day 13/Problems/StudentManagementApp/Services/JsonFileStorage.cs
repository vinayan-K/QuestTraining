using Newtonsoft.Json;
using StudentManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp.Services
{
    internal class JsonFileStorage : IStorageService
    {
        private readonly string _storagedirectory;
        public JsonFileStorage()
        {
            var documentspath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            _storagedirectory = Path.Combine(documentspath, "StudentManagementApp", "JsonFiles");
            Directory.CreateDirectory(_storagedirectory);
        }

        public void Delete(string id)
        {
            var filePath = Path.Combine(_storagedirectory, $"{id}.json");
            File.Delete(filePath);
            Console.WriteLine("Deleted successfully");
        }

        public void Save(Student student)
        {
            var jasonText = JsonConvert.SerializeObject(student);
            var filePath = Path.Combine(_storagedirectory, $"{student.Id}.json");
            File.WriteAllText(filePath, jasonText);
            Console.WriteLine("Added successfully");
        }

        public Student SearchById(string id)
        {
            var files = Directory.GetFiles(_storagedirectory);
            foreach (var file in files)
            {
                var fileContentJson = File.ReadAllText(file);
                var student = JsonConvert.DeserializeObject<Student>(fileContentJson);

                var employeeId = student.Id.ToString();

                if (employeeId.Contains(id))
                {
                    return student;
                }

            }
            return null;
        }

        public Student SearchByName(string name)
        {
            var files = Directory.GetFiles(_storagedirectory);
            foreach (var file in files)
            {
                var fileContantJson = File.ReadAllText(file);
                var student = JsonConvert.DeserializeObject<Student>(fileContantJson);
                var studentName = student.FullName.ToLowerInvariant();
                var nameToSearch = name.ToLowerInvariant();

                if (studentName.Contains(nameToSearch))
                {
                    return student;
                }

            }
            return null;
        }
    }
}
