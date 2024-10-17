using StudentManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp.Services
{
    internal interface IStorageService
    {
        void Save(Student student);

        Student SearchById(string id);
        Student SearchByName(string name);
        void Delete(string id);
    }
}
