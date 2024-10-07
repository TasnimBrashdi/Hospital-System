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

        public Specialization Special { get; set; }
        public enum Specialization
        {
            Cardiology, Neurology, Dermatology
        }
        public List<Patient> PatientsList;
        public List<Clinic> AssignedClinics;
   
        public Doctor(int DoctorID, string Name, int age, Gender gender, Specialization Special) : base(Name, age, gender)
        {
       
            this.DoctorID = DoctorID;
            this.Special = Special;
            AssignedClinics = new List<Clinic>(); 
            PatientsList = new List<Patient>(); 


        }
        public void  AssignToClinic (Clinic clinic, DateTime day, TimeSpan period)
        {
           
            if (AssignedClinics == null)
            {
                AssignedClinics = new List<Clinic>();
            }

            if (!AssignedClinics.Contains(clinic))
            {
              
              
                clinic.AddAvailableAppointment(this, day, period);
                AssignedClinics.Add(clinic);

            }

            if (!clinic.AvailableAppointments.ContainsKey(this))
            {
                clinic.AvailableAppointments[this] = new List<Appointment>();
            }
            DateTime startTime = day.Date.AddHours(9);
            DateTime endTime = startTime.Add(period);

            Console.WriteLine($"Doctor: {Name} is assigned to the {clinic.ClinicName} for {day:MMMM d, yyyy}, {startTime:hh:mm tt} to {endTime:hh:mm tt}.");

          

        }
        public void DisplayAssignedClinics()
        {
           
            foreach (var clinic in AssignedClinics)
            {
                Console.WriteLine($"Assigned Clinics for {Name}: {clinic.ClinicName}");
                Console.WriteLine();
            }
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
            Console.WriteLine($"Doctor Id : {DoctorID} Specialization: {Special}");

        }


    }
}
