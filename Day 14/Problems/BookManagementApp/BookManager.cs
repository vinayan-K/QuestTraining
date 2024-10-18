using BookManagementApp.Entiites;
using BookManagementApp.Entiites.Category;
using BookManagementApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementApp
{
    internal class BookManager
    {
        private readonly IStorageService _storageService;
        public BookManager(IStorageService storageService)
        {
            _storageService = storageService;
        }

        public void Add()
        {
            var book = new Book();
            book.id = Guid.NewGuid().ToString();
            Console.Write("Enter the title of the book: ");
            book.Title = Console.ReadLine();
            Console.Write("Enter the author of the book: ");
            book.AuthorName = Console.ReadLine();
            Console.Write("Enter the price of the book: ");
            book.Price = Console.ReadLine();
            Console.Write("Enter the number of pages: ");
            book.NumberOfPages = int.Parse(Console.ReadLine());
            Console.WriteLine("Enteer the Category :1.Novel, 2.Story");
            var bookCategory = Console.ReadLine();
            book.BookCategory = bookCategory == "1" ? BookCategory.Novel : BookCategory.Story;

            _storageService.Add(book);

        }
        public void Remove()
        {
            Console.WriteLine("Enter book id for delete");
            var id = Console.ReadLine();
            _storageService.Remove(id);
        }
        public void Search()
        {
            Console.WriteLine("Enter the name for search:");
            var name = Console.ReadLine();
            var book = _storageService.Search(name);
            if (book == null)
            {
                Console.WriteLine("Book Not Found");
            }
            Console.WriteLine(book);
        }
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Search Book by title");
                Console.WriteLine("3. Remove Book");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Search();
                        break;
                    case "3":
                        Remove();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }

    }
}
