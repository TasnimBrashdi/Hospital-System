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
         //public Doctor AssignedDoctor;
         //public Room Room;
        public Patient(int PatientID, string Name,int age,Gender gender, string Ailment) : base (Name,age,gender) {
            this.PatientID = PatientID;
            this.Ailment = Ailment;
            //this.AssignedDoctor = AssignedDoctor;
          

        }
       
      
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Patient Id : {PatientID} Ailment: {Ailment}");
        }

    }
}
