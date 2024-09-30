using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public void ScheduleAppointment(DateTime date)
        {
            AppointmentDate = date;

        }
        public void CancelAppointment(DateTime date) {


            AppointmentDate = date;
            Console.WriteLine($"Patient's Name:{Patient.Name} Doctor' Name: {Doctor.Name}  Appointment Date: {AppointmentDate}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Canceled");

        }
        public void GetAppointmentDetails()
        {
            Console.WriteLine($"Patient's Name:{Patient.Name} Doctor' Name: {Doctor.Name}  Appointment Date: {AppointmentDate}");
        }
    }
}
