using AcademyG.Week1.FactoryPattern.Vehicles;
using System;

namespace AcademyG.Week1.FactoryPattern
{
    class Program
    {
        //CREARE UN VEICOLO SULLA BASE DEL NUMERO DI RUOTE
        static void Main(string[] args)
        {
            int numWheels;
            Console.WriteLine("How many wheels?");
            IVehicle vehicle = null;
            try
            {
                
                numWheels = int.Parse(Console.ReadLine());

                #region CREAZIONE SENZA DESIGN PATTERN
                //APPROCCIO SENZA DESIGN PATTERN
                //switch (numWheels)
                //{
                //    case 1:
                //        Console.WriteLine("No vehicle with one wheel");
                //        //vehicle = null;
                //        break;
                //    case 2:
                //        vehicle = new Bike { Name = "Bike-01", Model = "Speed"};
                //        break;
                //    case 4:
                //        vehicle = new Car() { Name = "Car-01", Model = "Kia Motors"};
                //        break;
                //    case 8:
                //        vehicle = new Truck() { Name = "Truck-01", Model = "IVECO"};
                //        break;
                //    default:
                //        //vehicle = null;
                //        break;
                //}
                #endregion

                VehicleFactory factory = new VehicleFactory(numWheels);
                vehicle = factory.CreateVehicle();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            numWheels = 5;
            if(vehicle != null)
            {
                vehicle.TravelTo("Vienna");
            }
            
        }
    }
}
