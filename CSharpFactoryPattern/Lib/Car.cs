using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFactoryPattern.Lib
{
    class Car:IVehicle
    {
        private readonly int Wheels;
        public Car()
        {
            Wheels = 4;
        }
        public int NumberOfWheels()
        {
            return Wheels;
        }
        public string VehicleType()
        {
            return "Motor Car";
        }
    }
}
