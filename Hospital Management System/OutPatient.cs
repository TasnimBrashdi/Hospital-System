using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Hospital_Management_System.person;

namespace Hospital_Management_System
{
    public class OutPatient :Patient
    {
        public Clinic ClinicAssigned { get; set; }
        public OutPatient(int PatientID, string Name, int age, Gender gender, string Ailment, Clinic ClinicAssigned) : base(PatientID, Name, age, gender, Ailment)
        {
            this.ClinicAssigned = ClinicAssigned;

        }
    }
    
}
