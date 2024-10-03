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
            Appointment newAppointment = new Appointment(null, doctor, appointmentDay);

            // Check if the doctor already has a appointments
            if (AvailableAppointments.ContainsKey(doctor))
            {
                // If the doctor exists, add the new appointment to their list
                //newAppointment.ScheduleAppointment(null, appointmentDay,)
                AvailableAppointments[doctor].Add(newAppointment);
                Console.WriteLine($"Availble appointment added for {doctor.Name} at {appointmentDay}");
            }
            else
            {
                // If the doctor does not exist, create a new list and add the appointment
                AvailableAppointments[doctor] = new List<Appointment> { newAppointment };
            }

        }
        public void BookAppointment(Patient patient, Doctor doctor, DateTime appointmentDay,TimeSpan appointmentTime)
        {
            if (!AvailableAppointments.ContainsKey(doctor))
            {
               Console.WriteLine("No Availbale Appointment for doctor");
                return;
            }
            Appointment availableAppointment= AvailableAppointments[doctor].Find(app => app.AppointmentDate == appointmentDay.Date && app.AppointmentTime == appointmentTime &&!app.IsBooked);
            if (availableAppointment == null)
            {

                Console.WriteLine("No Avalibale Appointment at this Date");
            }
            else
            {
                availableAppointment.Patient = patient;
                availableAppointment.ScheduleAppointment(appointmentDay, appointmentTime);
                //clinic.BookAppointment(this, patient, doctor, appointmentDay, appointmentTime);
                Console.WriteLine($"Appointment booked for {patient.Name} with  {doctor.Name} on {appointmentDay.ToShortDateString()} at {appointmentTime}.");
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
