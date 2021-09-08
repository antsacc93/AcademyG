using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.FactoryPattern.Vehicles
{
    public class Bike : IVehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public void TravelTo(string destination)
        {
            Console.WriteLine($"Road to {destination} with my bike {Name} - {Model}");
        }
    }
}
