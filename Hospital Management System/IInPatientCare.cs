using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public interface IInPatientCare: IPatientCare
    {
        void AssignRoom(Room Room);
        void Discharge();

    }
}
