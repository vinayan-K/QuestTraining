using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Database
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\acer\Documents\dataDB.mdf; Integrated Security=True;";
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connStr))
            {

                conn.Open();
                string query = "SELECT * FROM Contacts";
                var adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows) 
                {
                    Console.WriteLine(row["Name"] + " - " + row["Email"]);
                }
            }
            Console.WriteLine("Task Completed");
        }
    }
}
