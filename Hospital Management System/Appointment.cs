using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hospital_Management_System
{

    public class Appointment : Scheduling, IDisplayInfo
    {
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime? AppointmentDate;
        public TimeSpan? AppointmentTime;
        public bool IsBooked { get; set; }
        public Appointment(Patient Patient, DateTime AppointmentDate,TimeSpan time)
        {
            this.Patient = Patient;
           
            this.AppointmentDate = AppointmentDate;
            IsBooked = false;
    
        }
        public void ScheduleAppointment(Patient patient, DateTime appointmentDate, TimeSpan appointmentTime,bool isBooked)
        {
            Patient = patient;
            AppointmentDate = appointmentDate;
            AppointmentTime = appointmentTime;  
            this.IsBooked = isBooked;

        }
        public void CancelAppointment(Patient Patient, Doctor Doctor,DateTime appointmentDate, TimeSpan appointmentTime) {
     
          
                Patient = null;
                Doctor = Doctor;
                AppointmentDate = appointmentDate;
                AppointmentTime = appointmentTime;
                IsBooked = false;       
          
        
         

        }
        public void DisplayInfo() 
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
