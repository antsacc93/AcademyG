using AcademyG.Week1.FactoryPattern.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.FactoryPattern
{
    public class VehicleFactory
    {
        public int NumWheels { get; set; }

        public VehicleFactory(int num)
        {
            NumWheels = num;
        }

        public IVehicle CreateVehicle()
        {
            IVehicle vehicle = null;
            switch (NumWheels)
            {
                case 1:
                    Console.WriteLine("No vehicle with one wheel");
                    //vehicle = null;
                    break;
                case 2:
                    vehicle = new Bike { Name = "Bike-01", Model = "Speed" };
                    break;
                case 4:
                    vehicle = new Car() { Name = "Car-01", Model = "Kia Motors" };
                    break;
                case 8:
                    vehicle = new Truck() { Name = "Truck-01", Model = "IVECO" };
                    break;
                default:
                    //vehicle = null;
                    break;
            }

            return vehicle;
        }
    }
}
