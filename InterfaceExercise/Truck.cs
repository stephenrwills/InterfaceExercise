using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle
    {
        public bool HasTowCapacity { get; set; }
        public bool HasBed { get; set; }
        public string CompanyName { get; set; }
        public int Employees { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }
        public double Length { get; set; }
        public string Model { get; set; }
    }
}
