using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal partial class Program
    {

        const string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\Assesment2Db.mdf;Integrated Security=True";

        public class DoctorRepository
        {
            public DoctorRepository()
            {
                CreateDoctorTable();
            }

            private void CreateDoctorTable()
            {
                string createTableQuery = @"
        CREATE TABLE Doctor (
            Id INT PRIMARY KEY IDENTITY(1,1),
            Name VARCHAR(100) NOT NULL,
            Specialization VARCHAR(50) NOT NULL,
            PatientId INT NULL,
            CONSTRAINT FK_Patient_Id FOREIGN KEY (PatientId) REFERENCES Patient(PatientId)
        );";

                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    SqlCommand command = new SqlCommand(createTableQuery, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            public void AddDoctor(Doctor doctor)
            {
                string query = "INSERT INTO Doctor (Name, Specialization, PatientId) VALUES (@Name, @Specialization, @PatientId)";
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", doctor.Name);
                    command.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                    command.Parameters.AddWithValue("@PatientId", doctor.PatientId);

                    connection.Open();
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
                                PatientId = reader.IsDBNull(3) ? (int?)null : reader.GetInt32(3),
                            });
                        }
                    }
                }

                return doctors;
            }

            public void UpdateDoctor(Doctor doctor)
            {
                string query = "UPDATE Doctor SET Specialization = @Specialization WHERE Id = @Id";
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                    command.Parameters.AddWithValue("@Id", doctor.Id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            public void DeleteDoctor(int doctorId)
            {
                string query = "DELETE FROM Doctor WHERE Id = @DoctorId";
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DoctorId", doctorId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public class PatientRepository
        {
            public PatientRepository()
            {
                CreatePatientTable();
            }

            private void CreatePatientTable()
            {
                string createTableQuery = @"
        CREATE TABLE Patient (
            PatientId INT PRIMARY KEY IDENTITY,
            Name VARCHAR(100) NOT NULL,
            Age INT NOT NULL,
            MedicalCondition VARCHAR(50) NOT NULL
        );";

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

                    connection.Open();
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

                return patients;
            }

            public void UpdatePatient(Patient patient)
            {
                string query = "UPDATE Patient SET MedicalCondition = @MedicalCondition WHERE PatientId = @PatientId";
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MedicalCondition", patient.MedicalCondition);
                    command.Parameters.AddWithValue("@PatientId", patient.PatientId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            public void DeletePatient(int patientId)
            {
                string query = "DELETE FROM Patient WHERE PatientId = @PatientId";
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PatientId", patientId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        static void Main(string[] args)
        {
            var patientRepository = new PatientRepository();
            patientRepository.AddPatient(new Patient
            {
                Name = "John Doe",
                Age = 20,
                MedicalCondition = "Fever"
            });

            var doctorRepository = new DoctorRepository();
            doctorRepository.AddDoctor(new Doctor
            {
                Name = "Dr. John Smith",
                Specialization = "Cardiology",
                PatientId = 1 
            });
        }

    }
}
}
