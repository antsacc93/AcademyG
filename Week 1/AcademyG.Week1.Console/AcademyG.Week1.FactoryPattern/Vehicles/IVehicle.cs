using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.FactoryPattern.Vehicles
{
    public interface IVehicle
    {
        string Name { get; set; }
        string Model { get; set; }

        void TravelTo(string destination);
    }
}
