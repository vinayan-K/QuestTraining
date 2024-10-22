using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConnectionString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connstr = @" Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\acer\Documents\QuestDb.mdf; Integrated Security = True";
            //var createTableQuerry = @"CREATE TABLE books
            //                        (
            //                          id INT PRIMARY KEY IDENTITY,
            //                          title VARCHAR(50) NOT NULL,
            //                          authorname VARCHAR(100) NOT NULL UNIQUE,                                       
            //                         )";
            //var conn = new SqlConnection(connstr);
            //conn.Open();
            //var command = new SqlCommand(createTableQuerry,conn);
            //command.ExecuteNonQuery();
            //conn.Close();
            //var conn = new SqlConnection(connstr);
            //conn.Open();
            //Console.WriteLine("Enter the name : ");
            //var title = Console.ReadLine();
            //Console.WriteLine("Enter the author name : ");
            //var authorname = Console.ReadLine();

            //var insertQuery = $"INSERT INTO books(title,authorname) VALUES (@title,@authorname)";
            //var command = new SqlCommand(insertQuery,conn);
            //{
            //    command.Parameters.AddWithValue("@title", title);
            //    command.Parameters.AddWithValue("@authorname", authorname);
            //    command.ExecuteNonQuery();
            //}
            //conn.Close();
            var conn = new SqlConnection(connstr);
            conn.Open();
            var selectquery = $"SELECT id, title, authorname FROM books";
            var command = new SqlCommand(selectquery, conn);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var title = reader.GetString(1);
                var authername = reader.GetString(2);
                Console.WriteLine($"{id} - {title} - {authername}");
            }
            conn.Close();
        }
    }
}
