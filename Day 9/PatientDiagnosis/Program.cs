using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDiagnosis
{
    internal class Program
    {
        static List<Dictionary<string, string>> patients = new List<Dictionary<string, string>>();
        static void AddPatient()
        {
            var patient = new Dictionary<string, string>();
            Console.WriteLine("Enter Patient Name: ");
            patient.Add("name",Console.ReadLine());

            Console.WriteLine("Enter Patient Age: ");
            patient.Add("age", Console.ReadLine());

            Console.WriteLine("Enter the symptoms as comma seperated vales: ");
            patient.Add("symptom", Console.ReadLine());

            var id = Guid.NewGuid().ToString();
            patient.Add("id",id);
            patients.Add(patient);
            Console.WriteLine($"patient added successfully id = {id}");
        }

        static void SearchPatient()
        {
            Console.WriteLine("Enter patient id:");
            var id = Console.ReadLine();
            foreach (var patient in patients)
            {
                if (patient["id"] == id)
                {
                    Console.WriteLine("Name: " + patient["name"]);
                    Console.WriteLine("Age: " + patient["age"]);
                    Console.WriteLine("Symptoms: " + patient["Symptoms"]);
                    break;
                }
            }
        }
        static void SearchBySymptom()
        {
            Console.WriteLine("Enter the Symptom for search");
            var symptom = Console.ReadLine();
            bool found = false; 
            foreach (var patient in patients)
            {
                if (patient["symptom"].Contains(symptom))
                {
                    Console.WriteLine("Name: " + patient["name"]);
                    Console.WriteLine("Age: " + patient["age"]);
                    found = true;
                }
            }
            if (!found) 
            {
                Console.WriteLine("NOT FOND");            
            }
        }
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Search Patient");
                Console.WriteLine("3. Search by symptoms");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddPatient();
                        break;
                    case "2":
                        SearchPatient();
                        break;
                    case "3":
                        SearchBySymptom();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }  
    }
}
