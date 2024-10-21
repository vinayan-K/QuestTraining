
using AssignmentHealthCare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var patients = new List<Patient>()
            {
                new Patient {PatientId = 1, Name = "p1", Age = 23, Gender = "Male", MedicalCondtion = "Fever" },
                new Patient {PatientId = 2, Name = "p2", Age = 26, Gender = "Female", MedicalCondtion = "Fatigue" },
                new Patient {PatientId = 3, Name = "p3", Age = 70, Gender = "Male", MedicalCondtion = "Cough" },
                new Patient {PatientId = 4, Name = "p4", Age = 65, Gender = "Female", MedicalCondtion = "Fever" },
            };
            var appoinments = new List<Appointment>()
            {
                new Appointment { AppointmentId = 1, PatientId = 1, DoctorName = "Doctor1", AppointmentDate = DateTime.Now.AddDays(2), AppointmentType = "Surgery" },
                new Appointment { AppointmentId = 2, PatientId = 2, DoctorName = "Doctor2", AppointmentDate = DateTime.Now.AddDays(8), AppointmentType = "Consultation" },
                new Appointment { AppointmentId = 3, PatientId = 3, DoctorName = "Doctor1", AppointmentDate = DateTime.Now.AddDays(3), AppointmentType = "Surgery" },
                new Appointment { AppointmentId = 4, PatientId = 4, DoctorName = "Doctor2", AppointmentDate = DateTime.Now.AddDays(9), AppointmentType = "Follow-Up" },
                new Appointment { AppointmentId = 5, PatientId = 1, DoctorName = "Doctor1", AppointmentDate = DateTime.Now.AddDays(6), AppointmentType = "Follow-Up" },
                new Appointment { AppointmentId = 6, PatientId = 2, DoctorName = "Doctor2", AppointmentDate = DateTime.Now.AddDays(10), AppointmentType = "Follow-Up" },
                new Appointment { AppointmentId = 7, PatientId = 2, DoctorName = "Doctor2", AppointmentDate = DateTime.Now.AddDays(-10), AppointmentType = "Follow-Up" },
                new Appointment { AppointmentId = 8, PatientId = 3, DoctorName = "Doctor2", AppointmentDate = DateTime.Now.AddDays(-15), AppointmentType = "Follow-Up" },
                new Appointment { AppointmentId = 9, PatientId = 2, DoctorName = "Doctor2", AppointmentDate = DateTime.Now.AddDays(-20), AppointmentType = "Follow-Up" },
                new Appointment { AppointmentId = 10, PatientId = 3, DoctorName = "Doctor2", AppointmentDate = DateTime.Now.AddDays(-5), AppointmentType = "Follow-Up" },
            };

            var appoinmentDetails = patients
                .Join(
                    appoinments,
                    p => p.PatientId,
                    a => a.PatientId,
                    (p, a) => new { Patient = p, Appointment = a })
                .Where(x =>
                {
                    return x.Appointment.AppointmentDate >= DateTime.Now &&
                           x.Appointment.AppointmentDate <= DateTime.Now.AddDays(7);
                })
                .Select(x => new
                {
                    PatientName = x.Patient.Name,
                    PatientAge = x.Patient.Age,
                    PatientMedication = x.Patient.MedicalCondtion,
                    AppointmentDate = x.Appointment.AppointmentDate,
                });
            foreach (var item in appoinmentDetails)
            {
                Console.WriteLine(item.PatientName + " , " + item.PatientAge + " , " + item.PatientMedication + " , " + item.AppointmentDate);
            }

            var medicalConditionGroups = patients.GroupBy(x => x.MedicalCondtion);
            foreach (var group in medicalConditionGroups)
            {
                Console.WriteLine($"{group.Key}  -  {group.Count()}");
            }

            var appoinmentGroups = appoinments.Where(x =>
            {
                return x.AppointmentDate >= DateTime.Now.AddDays(-30)
                       && x.AppointmentDate <= DateTime.Now;
            }).GroupBy(x => x.PatientId);
            foreach (var group in appoinmentGroups)
            {
                Console.WriteLine($"Patient Id: {group.Key}  -  No.of visits: {group.Count()}");
            }
            var mostVisitedPatient = appoinmentGroups.OrderByDescending(g => g.Count()).FirstOrDefault();
            Console.WriteLine($"Most visited patient Id: {mostVisitedPatient.Key}," +
                              $" Number of visits :{mostVisitedPatient.Count()}");

            var appoinmentDetailsByAge = patients
               .Join(
                   appoinments,
                   p => p.PatientId,
                   a => a.PatientId,
                   (p, a) => new { Patient = p, Appointment = a })
               .Where(x => x.Patient.Age > 60)
               .Select(x => new
               {
                   PatientName = x.Patient.Name,
                   PatientAge = x.Patient.Age,
                   DoctorName = x.Appointment.DoctorName,
                   PatientMedication = x.Patient.MedicalCondtion,
                   AppointmentDate = x.Appointment.AppointmentDate,
               });
            foreach (var item in appoinmentDetailsByAge)
            {
                Console.WriteLine(item.PatientName
                                  + " , "
                                  + item.PatientAge
                                  + " , "
                                  + item.DoctorName
                                  + " , "
                                  + item.PatientMedication
                                  + " , "
                                  + item.AppointmentDate);
            }

        }
    }
}
