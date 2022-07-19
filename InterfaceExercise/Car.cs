using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle
    {
        public bool HasTrunk { get; set; }

        public bool IsSedan { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Length { get; set; }
        public int Employees { get; set; }
        public string CompanyName { get; set; }
    }
}
