using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class InPatient : Patient, IInPatientCare
    {
        public Room Room { get; set; }
        public Doctor AssignedDoctor { get; set; }
        public DateTime AdmissionDate { get; set; }
        public InPatient( string Name, int age, Gender gender, int PatientID,  string Ailment, Doctor AssignedDoctor, DateTime AdmissionDate) : base(PatientID, Name, age, gender, Ailment)
        {
            this.Room = Room;
            this.AssignedDoctor = AssignedDoctor;
            this.AdmissionDate = AdmissionDate;

        }
        public void AssignRoom(Room Room)
        {
            this.Room = Room;
            Room.OccupyRoom();
            Console.WriteLine($" {Name} assigned to room {Room.RoomNumber} ");


        }
      
        public void Discharge()
        {
            Room.VacateRoom();
            Room = null;

        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Room : {Room} Assign Doctor: {AssignedDoctor}");

        }

    }
}
