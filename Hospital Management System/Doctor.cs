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
        public List<Patient> PatientsList;
   
        public Doctor(int DoctorID, string Name, int age, Gender gender, string Specialization) : base(Name, age, gender)
        {
       
            this.DoctorID = DoctorID;
            this.Specialization = Specialization;

        }
        public void AddPatient(Patient patient)
        {

            PatientsList.Add(patient);
            Console.WriteLine("Patient added");
        }
        public void RemovePatient(Patient patient) {
            if (PatientsList.Contains(patient))
            {
                PatientsList.Remove(patient);
                Console.WriteLine($"{patient.Name} Removed");

            }
            else {
                Console.WriteLine("Patient not found");
            }
        }
        public override void  DisplayInfo() {
            base.DisplayInfo();
            Console.WriteLine($"Doctor Id : {DoctorID} Specialization: {Specialization}");

        }


    }
}
