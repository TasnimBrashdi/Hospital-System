using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class Doctor : person
    {
        public int DoctorID;
        public string Specialization;
     ///continus
        public Doctor(string Name, int age, Gender gender, int PatientID, string Ailment, Doctor AssignedDoctor, Room Room) : base(Name, age, gender)
        {
          

        }
    
    }
}
