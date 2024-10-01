using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public  class InPatient : Patient
    {
        public Room Room { get; set; }
        public Doctor AssignedDoctor { get; set; }
        public DateTime AdmissionDate { get; set; } 
    public InPatient (int PatientID, string Name, int age, Gender gender, string Ailment, Doctor AssignedDoctor, Room Room, DateTime AdmissionDate) : base (PatientID, Name, age, gender,Ailment, AssignedDoctor)
        {
            this.Room = Room;
            this.AssignedDoctor = AssignedDoctor;
            this.AdmissionDate = AdmissionDate;

        }
    }
}
