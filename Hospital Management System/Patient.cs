﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class Patient : person
    {
         public int PatientID;
         public string Ailment;
         public Doctor AssignedDoctor;
         public Room Room;
        public Patient(string Name,int age,Gender gender,int PatientID, string Ailment,Doctor AssignedDoctor,Room Room) : base (Name,age,gender) {
            this.PatientID = PatientID;
            this.Ailment = Ailment;
            this.AssignedDoctor = AssignedDoctor;
            this.Room = Room;

        }
        public void AssignRoom(Room Room)
        {
            

        }
        public void Discharge()
        {
            Room = null;
        }
        public  void DisplayInfo(int PatientID, string Ailment)
        {

        }

    }
}
