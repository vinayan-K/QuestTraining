using BookManagementApp.Entiites.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BookManagementApp.Entiites
{
    internal class Book
    {
        public string id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string Price { get; set; }
        public int NumberOfPages { get; set; }
        public BookCategory BookCategory { get; set; }

        public override string ToString()
        {
            return $"{id}, {Title}, {AuthorName}";
        }

    }
}
