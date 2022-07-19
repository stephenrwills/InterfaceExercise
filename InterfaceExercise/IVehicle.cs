using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle : ICompany
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public string Color { get; set; }

        public double Length { get; set; }
    }
}
