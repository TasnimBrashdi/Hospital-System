using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class Nurse : person
    {
        public int NurseID;
        public Clinic AssignedClinic;
        public Specializations SpecialNurse { get; set; }
        public enum Specializations
        {
            General, Pediatrics, Surgery
        }
        public List<Patient> AssignedPatients;

        public Nurse(int NurseID, string Name, int age, Gender gender, Specializations SpecialNurse, Clinic AssignedClinic) : base(Name, age, gender)
        {
            AssignedPatients = new List<Patient>();
            this.NurseID = NurseID;
            this.AssignedClinic = AssignedClinic;
            this.SpecialNurse = SpecialNurse;

        }
    }
}
