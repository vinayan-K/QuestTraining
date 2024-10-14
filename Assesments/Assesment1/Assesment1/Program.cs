using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment1
{
    internal class Program
    {
        static List<Dictionary<string, string>> patients = new List<Dictionary<string, string>>();
        static void AddPatient()
        {
            var patient = new Dictionary<string,string>();
            Console.WriteLine("Enter the Patient name:");
            patient.Add("name", Console.ReadLine().ToLower());

            Console.WriteLine("Enter the Patient age:");
            patient.Add("age", Console.ReadLine());

            Console.WriteLine("Enter the Diagnosis:");
            patient.Add("diagnosis", Console.ReadLine());

            Console.WriteLine("Enter the Admission status:(Admitted/Discharged)");
            patient.Add("admissionStatus", Console.ReadLine().ToLower());

            patients.Add(patient);
            Console.WriteLine($"Patient Details Entered Successfully ");
            Console.WriteLine();

        }

        static void SearchPatient()
        {
            Console.WriteLine("Enter the patient name:");
            var searchName = Console.ReadLine();
            bool found = false;
            foreach (var patient in patients)
            {
                if (patient["name"] == searchName)
                {
                    Console.WriteLine("Name: " + patient["name"]);
                    Console.WriteLine("Age: " + patient["age"]);
                    Console.WriteLine("Diagnosis: " + patient["diagnosis"]);
                    Console.WriteLine("Admission Status: " + patient["admissionStatus"]);
                    found = true;
                    break;
                }
            }
            if (found != true)
            {
               Console.WriteLine("Patient Not Found");
            }            
            Console.WriteLine();
        }

        static void UpdateDetails()
        {  
            Console.WriteLine("1.Change Admission status");
            Console.WriteLine("2.Change Diagnosis");
            var changeOption = int.Parse( Console.ReadLine());
            Console.WriteLine("Enter The Patient Name:");
            var patientName = Console.ReadLine();
            bool found = false;
            foreach (var patient in patients)
            {
                if (patient["name"] == patientName)
                {
                    if (changeOption == 1)
                    {
                        Console.WriteLine("Enter New Status: ");
                        patient["admissionStatus"] = Console.ReadLine();
                        found = true;
                        break;
                    }
                    else if (changeOption == 2)
                    {
                        Console.WriteLine("Enter New Diagnosis: ");
                        patient["diagnosis"] = Console.ReadLine();
                        found = true;
                        break;
                    }
                }
            }
            if(found != true) 
            {
               Console.WriteLine("Patient Not Found");                    
            }                           
             Console.WriteLine();
        }

        static void PatientList()
        {
             
             foreach (var patient in patients)
             {
                if (patient["admissionStatus"] == "admitted")
                {                    
                    Console.WriteLine("Admitted Patient Name: " + patient["name"]);
                }
                else if (patient["admissionStatus"] == "discharged")
                {                  
                    Console.WriteLine("Discharged Patient Name: " + patient["name"]);
                }
             }            
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Add New Patient");
                Console.WriteLine("2.Search Patient By Name");
                Console.WriteLine("3.Update Patient Details");
                Console.WriteLine("4.Patient List");
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
                        UpdateDetails();
                        break;
                    case "4":
                        PatientList();
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }
    }
}
