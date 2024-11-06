using Assesment3.Entities;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment3.Repositories
{
    internal class NoteRepository : INoteRepository
    {

        const string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\NoteTakingApp.mdf;Integrated Security=True;Connect Timeout=30";
        public NoteRepository()
        {
            CreateNotesTable();
        }
        private void CreateNotesTable()
        {
            string createTableQuery = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Notes' AND xtype='U')
            BEGIN
            CREATE TABLE Notes (
            Id INT PRIMARY KEY IDENTITY,
            Title VARCHAR(50) NOT NULL,
            Content VARCHAR(100) NOT NULL,
            CreatedAt DATETIME,
            UpdatedAt DATETIME,
            );
            END";

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(createTableQuery, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void AddNote(Notes note)
        {
            string query = "INSERT INTO Notes (Title, Content, CreatedAt, UpdatedAt ) VALUES (@Title, @Content, @CreatedAt, @UpdatedAt)";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", note.Title);
                command.Parameters.AddWithValue("@Content", note.Content);
                command.Parameters.AddWithValue("@CreatedAt", note.CreatedAt);
                command.Parameters.AddWithValue("@UpdatedAt", note.UpdatedAt);

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                command.ExecuteNonQuery();
            }
        }
        public List<Notes> ViewAllNotes()
        {
            List<Notes> notes = new List<Notes>();
            string query = "SELECT * FROM Notes";

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        notes.Add(new Notes
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Content = reader.GetString(2),
                            CreatedAt = reader.GetDateTime(3),
                            UpdatedAt = reader.GetDateTime(4),
                        });
                    }
                }
            }
            foreach (var item in notes)
            {
                Console.WriteLine($" Id: {item.Id} - Title: {item.Title} - Content: {item.Content} - Created At: {item.CreatedAt} - Updated At: {item.UpdatedAt}");
            }
            return notes;
        }

        public void UpdateNote(int idToUpdate, string newContent, DateTime updatedTime)
        {
            string query = "UPDATE Notes SET Content = @content, UpdatedAt = @updatedAt WHERE Id = @idToUpdate";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@content", newContent);
                command.Parameters.AddWithValue("@updatedAt", updatedTime);
                command.Parameters.AddWithValue("@idToUpdate", idToUpdate);
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                command.ExecuteNonQuery();
            }
        }
        public void DeleteNote(int idToDelete)
        {
            string query = "DELETE FROM Notes WHERE Id = @idToDelete";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idToDelete", idToDelete);

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                command.ExecuteNonQuery();
            }
        }
        public bool CheckId(int id)
        {
            bool result = false;
            string query = "Select COUNT(id) FROM Notes WHERE Id = @id";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    result = true;
                }

                return result;
            }
        }
    }
}
