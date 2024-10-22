using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\BookDb.mdf;Integrated Security=True";
            //var createTableQuerry = @"CREATE TABLE Books
            //                        (
            //                         id INT PRIMARY KEY IDENTITY,
            //                         name VARCHAR(50) NOT NULL,
            //                         author VARCHAR(100) NOT NULL ,
            //                         price int NOT NULL,
            //                        )";
            //var conn = new SqlConnection(connstr);
            //conn.Open();
            //var command = new SqlCommand(createTableQuerry,conn);
            //command.ExecuteNonQuery();
            //conn.Close();

        var books = new List<Book>
        {
            new Book { Name = "1984", Author = "George Orwell", Price = 999 },
            new Book { Name = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 1499 },
            new Book { Name = "To Kill a Mockingbird", Author = "Harper Lee", Price = 1299 },
            new Book { Name = "Pride and Prejudice", Author = "Jane Austen", Price = 1199 },
            new Book { Name = "The Catcher in the Rye", Author = "J.D. Salinger", Price = 1099 }
        };
            var conn = new SqlConnection(connstr);
            conn.Open();
            foreach (var item in books)
            {
                var insertQuery = $"INSERT INTO Books(name,author,price) VALUES (@Name,@Author,@Price)";
                var command1 = new SqlCommand(insertQuery, conn);
                {
                    command1.Parameters.AddWithValue("@Name", item.Name);
                    command1.Parameters.AddWithValue("@Author", item.Author);
                    command1.Parameters.AddWithValue("@Price", item.Price);
                    command1.ExecuteNonQuery();
                }
            }
            conn.Close();
        }
    }
}
