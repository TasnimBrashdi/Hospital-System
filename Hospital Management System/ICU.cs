using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class ICU : IRoomManagement
    {
        public int ICUNumber { get; set; }
        public bool IsOccupied { get; set; }
        public ICU(int ICUNumber)
        {
            this.ICUNumber = ICUNumber;
            IsOccupied = false;
        }
        public void OccupyRoom()
        {
            IsOccupied = true;
        }
        public void VacateRoom()
        {
            IsOccupied = false;
        }
        public void DisplayInfo()
        {
            Console.WriteLine(" - - - ICU Information - - - ");
            Console.WriteLine($"ICU Number: {ICUNumber} Is Occupied  {IsOccupied}");
        }
        public bool IsRoomOccupied()
        {
            return IsOccupied;
        }
    }
}



















