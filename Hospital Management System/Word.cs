using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class Ward: IRoomManagement
    {

        public int WardNumber { get; set; }
        public int BedCount { get; set; }
        public int OccupiedBeds { get; set; }
        public Ward(int wardNumber, int bedCount)
        {
            WardNumber = wardNumber;
            BedCount = bedCount;
            OccupiedBeds = 0;
        }
        public void OccupyRoom()
        {
            if (OccupiedBeds < BedCount)
            {
                OccupiedBeds++;
            }
            else
            {
                Console.WriteLine("Ward is fully occupied.");
            }
        }
        public void VacateRoom()
        {
            if (OccupiedBeds > 0)
            {
                OccupiedBeds--;
            }
            else
            {
                Console.WriteLine("Ward is already empty.");
            }
        }
        public bool IsRoomOccupied()
        {
            return OccupiedBeds > 0;
        }
        public void DisplayInfo()
        {
            Console.WriteLine(" - - - Ward Information - - - ");
            Console.WriteLine($"Ward Number: {WardNumber} \nBed Count: {BedCount} \nOccupied Beds: {OccupiedBeds}");
        }
    }













    }

