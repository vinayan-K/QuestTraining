using BookManagement.Data;
using BookManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Repositories
{
    internal class BookRepository
    {
        public GenericResponses<List<Book>> GetAllBooks()
        {
            var books = DataStore.Books;
            return new GenericResponses<List<Book>>
            {
                Success = true,
                Data = books,
            };
        }
        public GenericResponses<Book> GetBookById(int id)
        {
            var books = DataStore.Books.FirstOrDefault(x => x.BookId == id);
            if (books == null)
            {
                return new GenericResponses<Book>
                {
                    Success = false,
                    Message = "Book not Found",
                };
            }
            return new GenericResponses<Book>
            {
                Success = true,
                Data = books,
            };
        }
    }
}
