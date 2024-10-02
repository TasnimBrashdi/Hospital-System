using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Hospital_Management_System.person;

namespace Hospital_Management_System
{
    public class OutPatient :Patient
    {
        public Clinic ClinicAssigned { get; set; }
        //private Clinic _clinic;
        public OutPatient( string Name, int age, Gender gender, int PatientID, string Ailment, Clinic ClinicAssigned) : base(PatientID, Name, age, gender, Ailment)
        {
            this.ClinicAssigned = ClinicAssigned;

        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Patient ID: {PatientID}, Ailment: {Ailment}, Assigned Clinic: {ClinicAssigned.ClinicName}");

            // Display upcoming appointments
            bool hasAppointments = false;

            foreach (var doctor in ClinicAssigned.AvailableAppointments.Keys)
            {
                if (ClinicAssigned.AvailableAppointments[doctor].Any(a => a.Patient == this && a.IsBooked))
                {
                    hasAppointments = true;
                    foreach (var appointment in ClinicAssigned.AvailableAppointments[doctor])
                    {
                        if (appointment.Patient == this && appointment.IsBooked)
                        {
                            Console.WriteLine($"Appointment with Dr. {doctor.Name} on {appointment.AppointmentDate}");
                        }
                    }
                }
            }

            if (!hasAppointments)
            {
                Console.WriteLine("No upcoming appointments.");
            }
        }
    }
    
}
