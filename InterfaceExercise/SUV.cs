using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle
    {
        public bool isLuxuryVehicle { get; set; }
        public bool Is4WD { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Length { get; set; }
        public string CompanyName { get; set; }
        public int Employees { get; set; }

        
    }
}
