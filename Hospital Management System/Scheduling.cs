using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public interface Scheduling
    {
        void ScheduleAppointment(Patient patient, DateTime appointmentDate, TimeSpan appointmentTime, bool isBooked);
        void CancelAppointment(Patient Patient, Doctor Doctor, DateTime appointmentDate, TimeSpan appointmentTime);


    }
}
