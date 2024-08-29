using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFactoryPattern.Lib
{
    class Bike:IVehicle
    {
        private readonly int Wheels;
        public Bike() 
        {
            Wheels = 2;
        }
        public int NumberOfWheels()
        {
            return Wheels;
        }
        public string VehicleType() 
        {
            return "Motor Cycle";
        }
    }
}
