using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var car1 = new Car()
            {
                IsSedan = true,
                Make = "Toyota",
                Model = "Camry",
                Color = "Red",
                Length = 12.25,
                CompanyName = "PepsiCo",
                Employees = 40000
            };

            var truck1 = new Truck()
            {
                HasBed = true,
                HasTowCapacity = true,
                Make = "Dodge",
                Model = "Ram",
                Color = "Green",
                Length = 15,
                CompanyName = "CocaCola",
                Employees = 50000

            };

            var SUV1 = new SUV()
            {
                isLuxuryVehicle = true,
                Is4WD = true,
                Make = "Hyundai",
                Model = "Tuscon",
                Color = "Blue",
                Length = 11,
                CompanyName = "Buffalo Rock",
                Employees = 500
            };

            var vehicles = new List<IVehicle>();

            vehicles.Add(car1);
            vehicles.Add(truck1);
            vehicles.Add(SUV1);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Length: {vehicle.Length}");
                Console.WriteLine($"Company Name: {vehicle.CompanyName}");
                Console.WriteLine($"Employees: {vehicle.Employees}");
            }


            
        }
    }
}
