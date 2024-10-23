﻿using HealthCare.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare
{
    internal class HealthCareManager
    {
        private DataStore _store;
        public HealthCareManager(DataStore _store)
        {
            _store = new DataStore();
        }

        public void ListUpcomingAppontmentsInNextSevenDays()
        {
            var result = _store.Appointments
                .Where(a => a.AppointmentDate >= DateTime.Now && a.AppointmentDate <= DateTime.Now.AddDays(7))
                .Join(_store.Patients,
                  a => a.PatientId,
                  p => p.Id,
                  (a, p) => new
                  {
                      Name = p.Name,
                      Id = p.Id,
                      MedicalCondition = p.MedicalCondition,
                      AppointmentDate = a.AppointmentDate,
                  }
                );
            Console.WriteLine("Patients with appoinment in 7 days :");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Id} - {item.MedicalCondition} - {item.MedicalCondition} - {item.AppointmentDate}");
            }
        }

        public void PatientsWithMostAppointmentsInLastThirtyDays()
        {
            var lastTirtyDays = DateTime.Now.AddDays(-30);
            var patientAppointmentCounts = _store.Appointments
                .Where(a => a.AppointmentDate >= lastTirtyDays && a.AppointmentDate <= DateTime.Now)
                .GroupBy(a => a.PatientId)
                .Select(g => new { PatientId = g.Key, Count = g.Count() })
                .OrderByDescending(g => g.Count)
                .ToList();

            var maxAppointmentCount = patientAppointmentCounts.First().Count;
            var mostActivePatientDetails = patientAppointmentCounts
                .Where(p => p.Count == maxAppointmentCount)
                .Join(_store.Patients,
                    p => p.PatientId,
                    m => m.Id,
                    (p, m) => new
                    {
                        Name = m.Name,
                        Age = m.Age,
                        MedicalCondition = m.MedicalCondition
                    }
                ).ToList();

            Console.WriteLine("Most active patients:");
            foreach (var item in mostActivePatientDetails)
            {
                Console.WriteLine($"{item.Name}, {item.Age}, {item.MedicalCondition}");
            }
        }

    }
}
