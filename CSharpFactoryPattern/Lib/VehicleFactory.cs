using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFactoryPattern.Lib
{
    class VehicleFactory
    {
        private readonly int Wheels;
        public static IVehicle GetVehicle(String type)
        {
            IVehicle vehicleType = null;
            if (type.ToLower().Equals("bike"))
            {
                vehicleType = new Bike();
            }
            else if (type.ToLower().Equals("car"))
            {
                vehicleType = new Car();
            }
            else if (type.ToLower().Equals("rikshaw"))
            {
                vehicleType = new Rickshaw();
            }
            else
            {
                throw new ArgumentException("Invalid notification type");
            }
            return vehicleType;
        }
        
    }
}
