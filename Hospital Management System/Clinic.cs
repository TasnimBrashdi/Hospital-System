using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class Clinic
    {
        public int ClinicID { get; set; }
        public string ClinicName { get; set; }
        public Specialization Special { get; set; }
        public enum Specialization
        {
            Cardiology, Neurology, Dermatology
        }
        public List<Room> Rooms;
        public Dictionary<Doctor, List<Appointment>> AvailableAppointments;


        public Clinic(int ClinicID, string ClinicName, Specialization Special, List<Room> Rooms, Dictionary<Doctor, List<Appointment>> AvailableAppointments) {
        this.ClinicID = ClinicID;
        this.ClinicName = ClinicName;
            this.Special = Special;
            this.Rooms = Rooms;
            this.AvailableAppointments = AvailableAppointments;
        }
    }
}
