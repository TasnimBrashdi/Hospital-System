using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hospital_Management_System
{
    public class Clinic
    {
        public int ClinicID { get; set; }
        public string ClinicName { get; set; }
        public Specializations Special { get; set; }
        public enum Specializations
        {
            Cardiology, Neurology, Dermatology
        }
        public List<Room> Rooms;
        public Dictionary<Doctor, List<Appointment>> AvailableAppointments;


        public Clinic(int ClinicID, string ClinicName, Specializations Special) {
        this.ClinicID = ClinicID;
        this.ClinicName = ClinicName;
            this.Special = Special;
            Rooms = new List<Room>();
            AvailableAppointments = new Dictionary<Doctor, List<Appointment>>(); ;
        }
        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }
        public void AddAvailableAppointment(Doctor doctor, DateTime appointmentDay, TimeSpan period)
        {
            // Assuming you want to add a new appointment without the time span for simplicity
         
            TimeSpan start =new TimeSpan (9,0,0);
            // Check if the doctor already has a appointments
            if (!AvailableAppointments.ContainsKey(doctor))
            {
                AvailableAppointments[doctor] = new List<Appointment>();
                // If the doctor exists, add the new appointment to their list
                for (int i=0; i <= period.Hours; i++)
                {
                    Appointment newAppointment = new Appointment(null, appointmentDay,start.Add(new TimeSpan (i,0,0)));
                    AvailableAppointments[doctor].Add(newAppointment);
                    Console.WriteLine($"Availble appointment added for {doctor.Name} at {appointmentDay}");
                }
               
            }
            else
            {
                // If the doctor does not exist, create a new list and add the appointment
                Console.WriteLine("Doctor already have appointment");
            }

        }
        public void BookAppointment(Patient patient, Doctor doctor, DateTime appointmentDay, TimeSpan appointmentTime)
        {
            // Check if there are available appointments for the selected doctor
            if (!AvailableAppointments.ContainsKey(doctor))
            {
                Console.WriteLine($" Sorry, Dr. {doctor.Name} does not have any available appointments at the moment.");
                return;
            }
            else
            {
                var availableAppointments = AvailableAppointments[doctor];
                // Search for the requested appointment
                foreach (var appointment in availableAppointments)
                {
                    if (appointment.AppointmentDate == appointmentDay && appointment.AppointmentTime == appointmentTime && !appointment.IsBooked)
                    {
                        // Book the appointment
                        appointment.Patient = patient;
                        appointment.IsBooked = true;
                        appointment.ScheduleAppointment(patient, appointmentDay, appointmentTime);
                    }

                    Console.WriteLine("Please try another time or day.");
                }

            }
            }
        
        public void DisplayAvailableAppointments()
        {
            foreach (var doctorAppointments in AvailableAppointments)
            {
                Doctor doctor = doctorAppointments.Key;
                List<Appointment> appointments = doctorAppointments.Value;
                Console.WriteLine($"Available Appointments for {doctor.Name}:");
                foreach (var appointment in appointments)
                {
                    if (!appointment.IsBooked)
                    {
                        Console.WriteLine($"Date: {appointment.AppointmentDate}  Time: {appointment.AppointmentTime}");
                    }
                }
            }
        }
    }
   
}
