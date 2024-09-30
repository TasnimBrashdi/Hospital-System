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
    }
}
