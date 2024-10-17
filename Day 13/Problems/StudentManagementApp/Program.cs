using StudentManagementApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var storageService = new JsonFileStorage();
            var studentManager = new StudentManager(storageService);
            studentManager.Run();
        }
    }
}
