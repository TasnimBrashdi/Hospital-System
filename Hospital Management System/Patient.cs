using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class Patient : person
    {
         public int PatientID;
         public string Ailment;
         public Doctor AssignedDoctor;
         public Room Room;
        public Patient(int PatientID, string Name,int age,Gender gender, string Ailment,Doctor AssignedDoctor) : base (Name,age,gender) {
            this.PatientID = PatientID;
            this.Ailment = Ailment;
            this.AssignedDoctor = AssignedDoctor;
          

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
            Console.WriteLine($"Patient Id : {PatientID} Ailment: {Ailment}");
        }

    }
}
