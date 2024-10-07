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
    public class Room: IRoomManagement
    {
        public int RoomNumber { get; set; }
        public bool IsOccupied { get; set; }
        public RoomType R { get; set; }
        public enum RoomType
        {
            IPR, OPR
        }
   
        
        public Room(int RoomNumber, RoomType R)
        {
            this.RoomNumber = RoomNumber;
            this.R = R; 
            this.IsOccupied = IsOccupied;
            }
        public void OccupyRoom()
        {
            IsOccupied=true;
       

        }
        public void VacateRoom()
        {
            IsOccupied = false;

        }
        public void DisplayRoomInfo()
        {
            Console.WriteLine(" - - - Room Information - - - ");
            Console.WriteLine($"Room Number: {RoomNumber} \nRoom Type: {R} \nIs Occupied ? {IsOccupied}");
        }

    }
}
