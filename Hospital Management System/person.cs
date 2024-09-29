using Hospital_Management_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class person
    {
    
        public string Name { get; set; }
        public int Age { get; set; }
        public  Gender gen { get; set; }
        public enum Gender
        {
            Male,
            Female,
            Other
        }
        public person(string Name, int Age,Gender gender)
        {
            this.Name = Name;
            this.Age = Age;
            Gender gen =gender;
          
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($" Name: {Name}\n Age:{Age} \nGender: {gen}");
        }
    }
   
}


