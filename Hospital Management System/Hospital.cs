using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class Hospital
    {
        public List<Doctor> DoctorsList;
        public List<Patient> PatientsList;
        public List<Room> RoomsList;
        public Hospital(List<Doctor> DoctorsLis,List<Patient> PatientsList, List<Room> RoomsList) {
            this.RoomsList = RoomsList;
            this.PatientsList = PatientsList;
            this.DoctorsList = DoctorsLis;
        
        }
        public void AddDoctor (Doctor doctor)
        {
            DoctorsList.Add(doctor);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("doctor added");
        }
        public void AddPatient(Patient patient)
        {

            PatientsList.Add(patient);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Patient added");
        }
        public void AssignRoomToPatient(Patient patient, Room room) {

            //patient.AssignRoom(room);


        }
        public void  GetDoctorPatients(Doctor doctor)
        {
            Console.WriteLine($"doctor name: {doctor.Name}");
            foreach(Patient d in doctor.PatientsList)
            {
                Console.WriteLine($"Patient Name {d.Name}\n Patient Id {d.PatientID}");
            }
           
        }
    }
}
