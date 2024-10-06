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
        public TimeSpan? AppointmentTime;
        public bool IsBooked { get; set; }
        public Appointment(Patient Patient, DateTime AppointmentDate,TimeSpan time)
        {
            this.Patient = Patient;
            this.Doctor = Doctor;
            this.AppointmentDate = AppointmentDate;
            IsBooked = false;
    
        }
        public void ScheduleAppointment(Patient patient, DateTime appointmentDate, TimeSpan appointmentTime)
        {
            Patient = patient;
            AppointmentDate = appointmentDate;
            AppointmentTime = appointmentTime;  
            IsBooked = true;

        }
        public void CancelAppointment(Patient Patient, Doctor Doctor,DateTime appointmentDate, TimeSpan appointmentTime) {

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
            AppointmentTime=null; 
            IsBooked = false;

        }
        public void DisplayAppointmentDetails() 
        {
            if (IsBooked)
            {
                Console.WriteLine($"Patient's Name: {Patient?.Name}, Appointment Date: {AppointmentDate} Appointment time: {AppointmentTime} ");
            }
            else
            {
                Console.WriteLine("No appointment details available.");
            }
        }
    }
}
