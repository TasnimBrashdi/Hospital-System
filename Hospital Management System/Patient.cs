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
         public string AssignedDoctor;
         public string Room;
        public Patient(string Name,int age,Gender gender): base (Name,age,gender) {
            

        }    

    }
}
