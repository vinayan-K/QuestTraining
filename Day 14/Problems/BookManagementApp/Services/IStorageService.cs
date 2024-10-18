using BookManagementApp.Entiites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementApp.Services
{
    internal interface IStorageService
    {
        void Add(Book book);
        void Remove(string id);
        Book Search(string name);
    }
}
