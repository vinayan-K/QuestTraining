using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentHealthCare
{
    internal class Appointment
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public string DoctorName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentType { get; set; }

    }
}
