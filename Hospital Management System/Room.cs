using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public RoomType R { get; set; }
        public enum RoomType
        {
            General, ICU, OperationTheater
        }
        public bool IsOccupied { get; set; }
        
        public Room(int RoomNumber, RoomType R,bool IsOccupied)
        {
            this.RoomNumber = RoomNumber;
            this.R = R; 
            this.IsOccupied = IsOccupied;
            }

    }
}
