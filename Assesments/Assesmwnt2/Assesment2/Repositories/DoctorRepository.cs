using Assesment2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2.Repositories
{
    internal class DoctorRepository
    {
        const string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\AssesmentDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        public DoctorRepository()
        {
            CreateDoctorTable();
        }
        private void CreateDoctorTable()
        {
            string createTableQuery = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Doctor' AND xtype='U')
            BEGIN
            CREATE TABLE Doctor (
            Id INT PRIMARY KEY IDENTITY(1,1),
            Name VARCHAR(100) NOT NULL,
            Specialization VARCHAR(50) NOT NULL,
            PatientId INT NULL,
            CONSTRAINT FK_Patient_Id FOREIGN KEY (PatientId) REFERENCES Patient(PatientId)
            );
            END";

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(createTableQuery, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void AddDoctor(Doctor doctor)
        {
            string query = "INSERT INTO Doctor (Name, Specialization, PatientId ) VALUES (@Name, @Specialization, @PatientId )";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", doctor.Name);
                command.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                command.Parameters.AddWithValue("@PatientId", doctor.PatientId ?? (object)DBNull.Value);

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                command.ExecuteNonQuery();
            }
        }
        public List<Doctor> ListingAll()
        {
            List<Doctor> doctors = new List<Doctor>();
            string query = "SELECT * FROM Doctor";

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        doctors.Add(new Doctor
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Specialization = reader.GetString(2),
                            PatientId = reader.GetInt32(3),
                        });
                    }
                }
            }
            foreach (var item in doctors)
            {
                Console.WriteLine($"{item.Name} - {item.Specialization}");
            }
            return doctors;
        }

        public void UpdateDoctor(int doctorIdToUpdate, string newSpecialization)
        {
            string query = "UPDATE Doctor SET Specialization = @specialization WHERE Id = @doctorIdToUpdate";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Specialization", newSpecialization);
                command.Parameters.AddWithValue("@doctorIdToUpdate", doctorIdToUpdate);
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                command.ExecuteNonQuery();
            }
        }
        public void DeleteDoctor(int idToDelete)
        {
            string query = "DELETE FROM Doctor WHERE Id = @idToDelete";
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

    }
}
