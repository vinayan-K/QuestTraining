using Assesment2.Models;
using Assesment2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2
{
    internal class Manager
    {
        private PatientRepository _patientRepository;
        private DoctorRepository _doctorRepository;
         public Manager()
        {
            _patientRepository = new PatientRepository();
            _doctorRepository = new DoctorRepository();
        }
        public void Add() 
        {
            Console.WriteLine("Enter 1:Doctor, 2:Patient");
            var res = Console.ReadLine();
            switch (res)
            {
                case "1":
                    var doctor = new Doctor();
                    Console.WriteLine("Enter the name:");
                    doctor.Name = Console.ReadLine();
                    Console.WriteLine("Enter Specialization :");
                    doctor.Specialization = Console.ReadLine();
                    Console.WriteLine("Enter Patient Id : ");
                    doctor.PatientId = Convert.ToInt32(Console.ReadLine());
                    _doctorRepository.AddDoctor(doctor);
                    break;
                case "2":
                    var patient = new Patient();
                    Console.WriteLine("Enter the name:");
                    patient.Name = Console.ReadLine();
                    Console.WriteLine("Enter Age:");
                    patient.Age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter medical codition : ");
                    patient.MedicalCondition = Console.ReadLine();
                    _patientRepository.AddPatient(patient);
                    break;
            }

        }
        
        public void Remove()
        {
            Console.WriteLine("Enter 1:Delete doctor, 2:Delete patient");
            var res = Console.ReadLine();
            Console.WriteLine("Enter the Id to delete: ");
            var idToDelete = int.Parse(Console.ReadLine());
            switch (res)
            {
                case "1":
                    _doctorRepository.DeleteDoctor(idToDelete);
                    break;
                case "2":
                    _patientRepository.DeletePatient(idToDelete);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
        public void ListAll()
        {
            Console.WriteLine("Enter 1:Doctor, 2:Patient");
            var res = Console.ReadLine().Trim();
            switch (res)
            {
                case "1":
                    _doctorRepository.ListingAll();
                    break;
                case "2":
                    _patientRepository.ListingAll();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
        public void Update ()
        {
            Console.WriteLine("Enter 1:Doctor, 2:Patient");
            var res = Console.ReadLine().Trim();

            switch (res)
            {
                case "1":
                    Console.WriteLine("Enter id : ");
                    var doctorIdToUpdate = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter new Specialization : ");
                    var newSpecialization = Console.ReadLine();
                    _doctorRepository.UpdateDoctor(doctorIdToUpdate, newSpecialization);
                    break;
                case "2":
                    Console.WriteLine("Enter id : ");
                    var patientIdToUpdate = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter new medical condition : ");
                    var newMedicalCondition = Console.ReadLine();
                    _patientRepository.UpdatePatient(patientIdToUpdate, newMedicalCondition);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            Console.WriteLine();
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Listing");
                Console.WriteLine("3.Update");
                Console.WriteLine("4.Delete");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        ListAll();
                        break;
                    case "3":
                        Update();
                        break;
                    case "4":
                        Remove();
                        break;
                    default:
                        Console.WriteLine("Invaild option");
                        break;
                }

            }
        }
    }
}
