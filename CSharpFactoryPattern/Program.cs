using CSharpFactoryPattern.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputVehicle = null;
            Console.WriteLine("Enter the Vehicle Type:");
            inputVehicle = Console.ReadLine();
            IVehicle vehicle = VehicleFactory.GetVehicle(inputVehicle);
            Console.WriteLine("Vehicle type is " + vehicle.VehicleType());
            Console.WriteLine("Number of wheels " + vehicle.NumberOfWheels());
            Console.ReadKey();
        }
    }
}
