using BookManagementApp.Entiites;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementApp.Services
{
    internal class JsonFileStorage : IStorageService
    {
        private readonly string _storageDirectory;
        public JsonFileStorage()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            _storageDirectory = Path.Combine(documentsPath, "BookManagementApp", "JsonFiles");
            Directory.CreateDirectory(_storageDirectory);
        }
        public void Add(Book book)
        {
            var jsonText = JsonConvert.SerializeObject(book);
            var filePath = Path.Combine(_storageDirectory, $"{book.id}.json");
            File.WriteAllText(filePath, jsonText);
        }

        public void Remove(string id)
        {
            var filePath = Path.Combine(_storageDirectory, $"{id}.json");
            File.Delete(filePath);
        }

        public Book Search(string name)
        {
            var files = Directory.GetFiles(_storageDirectory);
            foreach (var file in files)
            {
                var jsonContent = File.ReadAllText(file);
                Book book = JsonConvert.DeserializeObject<Book>(jsonContent);
                var nameToSearch = name.ToLowerInvariant();
                var bookname = book.Title.ToLowerInvariant();
                if (bookname.Contains(nameToSearch))
                {
                    return book;
                }                
            }
            return null;
        }
    }
}
