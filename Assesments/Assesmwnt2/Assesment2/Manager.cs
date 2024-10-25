using Assesment2.Entities;
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
        public void AddDoctor()
        {
            var doctor = new Doctor();
            Console.WriteLine("Enter the name:");
            doctor.Name = Console.ReadLine();
            Console.WriteLine("Enter Specialization :");
            doctor.Specialization = Console.ReadLine();
            Console.WriteLine("Enter Patient Id : ");
            doctor.PatientId = Convert.ToInt32(Console.ReadLine());
            _doctorRepository.AddDoctor(doctor);
        }
        public void AddPatient()
        {
            var patient = new Patient();
            Console.WriteLine("Enter the name:");
            patient.Name = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            patient.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter medical codition : ");
            patient.MedicalCondition = Console.ReadLine();
            _patientRepository.AddPatient(patient);
        }

        public void RemoveDoctor()
        {
            Console.WriteLine("Enter the Id to delete: ");
            var idToDelete = int.Parse(Console.ReadLine());
            _doctorRepository.DeleteDoctor(idToDelete);
        }
        public void RemovePatient()
        {
            Console.WriteLine("Enter the Id to delete: ");
            var idToDelete = int.Parse(Console.ReadLine());
            _patientRepository.DeletePatient(idToDelete);
        }

        public void ListAllDoctor()
        {
            _doctorRepository.ListingAll();
        }
        public void ListAllPatient()
        {
            _patientRepository.ListingAll();

        }

        public void UpdateDoctor()
        {
            Console.WriteLine("Enter id : ");
            var doctorIdToUpdate = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new Specialization : ");
            var newSpecialization = Console.ReadLine();
            _doctorRepository.UpdateDoctor(doctorIdToUpdate, newSpecialization);
        }
        public void UpdatePatient()
        {
            Console.WriteLine("Enter id : ");
            var patientIdToUpdate = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new medical condition : ");
            var newMedicalCondition = Console.ReadLine();
            _patientRepository.UpdatePatient(patientIdToUpdate, newMedicalCondition);
        }

        public void RunDoctor()
        {
            Console.WriteLine("1.AddDoctor");
            Console.WriteLine("2.Listing all doctors");
            Console.WriteLine("3.Update specialization");
            Console.WriteLine("4.Delete doctor");
            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    AddDoctor();
                    break;
                case "2":
                    ListAllDoctor();
                    break;
                case "3":
                    UpdateDoctor();
                    break;
                case "4":
                    RemoveDoctor();
                    break;
                default:
                    Console.WriteLine("Invaild option");
                    break;
            }
        }
        public void RunPatient()
        {
            Console.WriteLine("1.AddPatient");
            Console.WriteLine("2.Listing all patients");
            Console.WriteLine("3.Update medical condition");
            Console.WriteLine("4.Delete patient");
            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    AddPatient();
                    break;
                case "2":
                    ListAllPatient();
                    break;
                case "3":
                    UpdatePatient();
                    break;
                case "4":
                    RemovePatient();
                    break;
                default:
                    Console.WriteLine("Invaild option");
                    break;
            }


        }
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Enter 1: Doctor, 2: Patient");
                var res = Console.ReadLine();
                switch (res)
                {
                    case "1":
                        RunDoctor();
                        break;
                    case "2":
                        RunPatient();
                        break;
                    default:
                        Console.WriteLine("Invaild option");
                        break;
                }
            }
        }
    }
}
