using static Hospital_Management_System.Clinic;
using static Hospital_Management_System.Doctor;
using static Hospital_Management_System.person;
using static Hospital_Management_System.Room;

namespace Hospital_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create doctors
            Doctor doctor1 = new Doctor(1, "Dr. John Smith", 45, Gender.Male,Specialization.Cardiology);
            Doctor doctor2 = new Doctor(2, "Dr. Alice Brown", 38, Gender.Female,Specialization.Neurology);

            // Create clinics
            Clinic cardiologyClinic = new Clinic(1, "Cardiology Clinic",Specializations.Cardiology);
            Clinic neurologyClinic = new Clinic(2, "Neurology Clinic", Specializations.Neurology);

            // Assign doctors to clinics and generate appointment slots (9 AM - 12 PM)
            doctor1.AssignToClinic(cardiologyClinic, new DateTime(2024, 10, 5), TimeSpan.FromHours(3)); // Expected: Appointments generated for 9 AM, 10 AM, 11 AM
            doctor2.AssignToClinic(neurologyClinic, new DateTime(2024, 10, 6), TimeSpan.FromHours(3));  // Expected: Appointments generated for 9 AM, 10 AM, 11 AM

            // Create rooms for clinics
            Room room1 = new Room(101, RoomType.IPR);  // Room for in-patients
            Room room2 = new Room(102, RoomType.OPR);  // Room for out-patients
            cardiologyClinic.AddRoom(room1); // Expected: Room 101 added to Cardiology Clinic
            neurologyClinic.AddRoom(room2);  // Expected: Room 102 added to Neurology Clinic

            // Create patients
            InPatient inpatient1 = new InPatient(
                  "Jane Doe",
                   30,
                   Gender.Female,
                   101, 
                   "Cardiac Arrest",
                   doctor1,
                  DateTime.Now
                   );
            OutPatient outpatient1 = new OutPatient
           (
                "Mark Doe",
                28,
                Gender.Male,
                102,
                "Migraine",
                neurologyClinic
                   );
                                       // Assign room to in-patient
            inpatient1.AssignRoom(room1); // Expected: Room 101 becomes occupied
                                          // Book an appointment for out-patient in Cardiology Clinic

            cardiologyClinic.BookAppointment(outpatient1, doctor1, new DateTime(2024, 10, 5), TimeSpan.FromHours(10)); // Expected: Appointment at 10 AM booked


        }
    }
}
