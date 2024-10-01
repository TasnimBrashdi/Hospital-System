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
        public DateTime? AppointmentDate;
        public TimeSpan AppointmentTime;
        public bool IsBooked { get; set; }
        public Appointment(Patient Patient, Doctor Doctor, DateTime AppointmentDate)
        {
            this.Patient = Patient;
            this.Doctor = Doctor;
            this.AppointmentDate = AppointmentDate;
    
        }
        public void ScheduleAppointment(DateTime date)
        {
            AppointmentDate = date;
            IsBooked = true;

        }
        public void CancelAppointment(DateTime date) {

            if (Patient != null && Doctor != null)
            {
                Console.WriteLine($"Patient's Name: {Patient.Name}, Doctor's Name: {Doctor.Name}, Appointment Date: {AppointmentDate}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Canceled");
            }
            else
            {
                Console.WriteLine("No appointment to cancel.");
            }

        
            Patient = null;
            Doctor = null;
            AppointmentDate = null;
            IsBooked = false;

        }
        public void GetAppointmentDetails()
        {
            if (IsBooked)
            {
                Console.WriteLine($"Patient's Name: {Patient?.Name}, Doctor's Name: {Doctor?.Name}, Appointment Date: {AppointmentDate}");
            }
            else
            {
                Console.WriteLine("No appointment details available.");
            }
        }
    }
}
