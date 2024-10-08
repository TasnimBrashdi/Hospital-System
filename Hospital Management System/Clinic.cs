using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hospital_Management_System
{
    public class Clinic: IDisplayInfo
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
            TimeSpan startTime = new TimeSpan(9, 0, 0);
            if (!AvailableAppointments.ContainsKey(doctor))
            {
                AvailableAppointments[doctor] = new List<Appointment>();
                for (int i = 0; i < period.TotalHours; i++)
                {
                    Appointment newAppointment = new Appointment(null, appointmentDay, startTime.Add(new TimeSpan(i, 0, 0)));
                    newAppointment.ScheduleAppointment(null, appointmentDay, startTime.Add(new TimeSpan(i, 0, 0)),false);
                    AvailableAppointments[doctor].Add(newAppointment);
                    Console.WriteLine($"Available appointment added for {doctor.Name} at {startTime.Add(new TimeSpan(i, 0, 0))}.");
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
                List<Appointment> availableAppointments = AvailableAppointments[doctor];
                // Search for the requested appointment
                foreach (var appointment in availableAppointments)
                {
                    if (appointment.AppointmentDate == appointmentDay && appointment.AppointmentTime == appointmentTime && !appointment.IsBooked)
                    {
                        appointment.ScheduleAppointment(patient, appointmentDay, appointmentTime,true);
                        
                        Console.WriteLine($"Appointment scheduled for {patient.Name} with  {doctor.Name} on{appointmentDay:MMMM d, yyyy} at {appointmentTime} ");
       

                    }


                }

            }

            }
        public void cancelapp(Patient patient, Doctor doctor, DateTime appointmentDay, TimeSpan appointmentTime)
        {
            if (!AvailableAppointments.ContainsKey(doctor))
            {
                Console.WriteLine($" Sorry, Dr. {doctor.Name} does not have any available appointments at the moment.");
                return;
            }
            else
            {
                List<Appointment> availableAppointments = AvailableAppointments[doctor];
                // Search for the requested appointment
                foreach (var appointment in availableAppointments)
                {
                    if (appointment.AppointmentDate == appointmentDay && appointment.AppointmentTime == appointmentTime && appointment.IsBooked)
                    {
                        appointment.ScheduleAppointment(patient, appointmentDay, appointmentTime, true);
                        appointment.CancelAppointment(null, doctor, appointmentDay, appointmentTime);

                        Console.WriteLine($"Appointment scheduled for {patient.Name} with  {doctor.Name} on{appointmentDay:MMMM d, yyyy} at {appointmentTime} ");
                        Console.WriteLine("----Canceled-----");


                    }


                }

            }
        }



        public void DisplayInfo()
        {
            
            foreach (var doctorAppointments in AvailableAppointments.Keys)
            {
                Console.WriteLine($"Available Appointments for {doctorAppointments.Name}:");
                List<Appointment> appointments = AvailableAppointments[doctorAppointments];
               
                foreach (var appointment in appointments)
                {
                    if (!appointment.IsBooked)
                    {
                        Console.WriteLine($"Date: {appointment.AppointmentDate:MMMM d, yyyy} {appointment.AppointmentTime} isBooked");
                    }
                    else
                    {
                        Console.WriteLine($"Date: {appointment.AppointmentDate:MMMM d, yyyy} {appointment.AppointmentTime} NotBooked");
                    }
                }
            }
        }
    }
   
}
