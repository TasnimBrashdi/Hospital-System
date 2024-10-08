using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class Nurse : person, IDisplayInfo, IPatientCare
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
        public void AssistDoctor(Doctor doctor, Patient patient)
        {
            doctor.AddPatient(patient);
            Console.WriteLine($"{Name} is assisting Dr. {doctor.Name} with patient {patient.Name}.");
        }
        public void CheckVitals(Patient patient)
        {
            Console.WriteLine($"Checking vitals for {patient.Name}.");
        }
        public void AdministerMedication(Patient patient, string medication)
        {
            Console.WriteLine($"{Name} is administering {medication} to {patient.Name}.");
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"_____Nurse’s information_____");
            Console.WriteLine($"-Nurse ID: {NurseID}");
            Console.WriteLine($"-Name: {Name}");
            Console.WriteLine($"-Age: {Age}");
            Console.WriteLine($"-Assigned Clinic: {AssignedClinic.ClinicName}");
            Console.WriteLine($"-Specialization: {SpecialNurse}");
            Console.WriteLine($"-Assigned Patients: {AssignedPatients.Count}");
        }


    }
}
