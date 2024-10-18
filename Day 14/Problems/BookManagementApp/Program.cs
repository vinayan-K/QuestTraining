using BookManagementApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var storageservice = new JsonFileStorage();
            var bookManager = new BookManager(storageservice);
            bookManager.Run();
        }
    }
}
