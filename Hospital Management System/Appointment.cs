using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class Appointment
    {
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime AppointmentDate;
        public Appointment(Patient Patient, Doctor Doctor, DateTime AppointmentDate)
        {
            this.Patient = Patient;
            this.Doctor = Doctor;
            this.AppointmentDate = AppointmentDate;

        }
    }
}
