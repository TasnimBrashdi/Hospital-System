using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public interface IRoomManagement
    {
        void OccupyRoom();
        void VacateRoom();
        void DisplayRoomInfo();
    }
}
