using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFactoryPattern.Lib
{
    class Rickshaw:IVehicle
    {
        private readonly int Wheels;
        public Rickshaw()
        {
            Wheels = 3;
        }
        public int NumberOfWheels()
        {
            return Wheels;
        }
        public string VehicleType()
        {
            return "Three Wheelers";
        }
    }
}
