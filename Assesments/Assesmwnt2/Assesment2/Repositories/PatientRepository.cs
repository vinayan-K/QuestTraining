using Assesment2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2.Repositories
{
    internal class PatientRepository
    {
        const string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\AssesmentDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        public PatientRepository()
        {
            CreatePatientTable();
        }
       private void CreatePatientTable()
        {
            string createTableQuery = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Patient' AND xtype='U')
            BEGIN          
            CREATE TABLE Patient (
                PatientId INT PRIMARY KEY IDENTITY,
                Name VARCHAR(100) NOT NULL,
                Age INT NOT NULL,
                MedicalCondition VARCHAR(50) NOT NULL,                             
            )
            END";

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(createTableQuery, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void AddPatient(Patient patient)
        {
            string query = "INSERT INTO Patient (Name, Age, MedicalCondition) VALUES (@Name, @Age, @MedicalCondition)";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", patient.Name);
                command.Parameters.AddWithValue("@Age", patient.Age);
                command.Parameters.AddWithValue("@MedicalCondition", patient.MedicalCondition);

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                command.ExecuteNonQuery();
            }
        }
        public List<Patient> ListingAll()
        {
            List<Patient> patients = new List<Patient>();
            string query = "SELECT * FROM Patient";

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);             
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        patients.Add(new Patient
                        {
                            PatientId = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Age = reader.GetInt32(2),
                            MedicalCondition = reader.GetString(3),
                        });
                    }
                }
            }           
            foreach (var item in patients)
            {
                Console.WriteLine($"{item.Name} - {item.MedicalCondition}");
            }
            return patients;
        }


        public void UpdatePatient(int patientIdToUpdate, string newMedicalCondition)
        {
            string query = "UPDATE Patient SET MedicalCondition = @MedicalCondition WHERE PatientId = @patientIdToUpdate";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);               
                command.Parameters.AddWithValue("@MedicalCondition", newMedicalCondition);
                command.Parameters.AddWithValue("@patientIdToUpdate", patientIdToUpdate);
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                command.ExecuteNonQuery();
            }
        }
        public void DeletePatient(int idToDelete)
        {
            string query = "DELETE FROM Patient WHERE PatientId = @idToDelete";
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
