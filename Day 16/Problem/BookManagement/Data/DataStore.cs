using BookManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Data
{
    internal class DataStore
    {
        public static List<Book> Books;
        public static List<Members> Members;

        static DataStore()
        {
            Books = new List<Book>()
            {
                new Book{BookId = 1, Title = "1984", AuthorName = "Author1" },
                new Book{BookId = 2, Title = "The Great Gatsby", AuthorName = "Author2" },
                new Book{BookId = 3, Title = "To Kill a Mockingbird", AuthorName = "Author3" },
            };
            Members = new List<Members>()
            {
                new Members { MemberId = 1, MemberName = "Member1", Email = "member1@gmail.com" },
                new Members { MemberId = 2, MemberName = "Member2", Email = "member2@gmail.com" },
                new Members { MemberId = 3, MemberName = "Member3", Email = "member3@gmail.com" },
            };
        }
    }
}
