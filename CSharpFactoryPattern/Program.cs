using CSharpFactoryPattern.FactoryPattern;
using CSharpFactoryPattern.Lib;
using CSharpFactoryPattern.Repository;
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
            // Create factories
            var userFactory = new UserFactory();
            var productFactory = new ProductFactory();

            // Create repositories
            var userRepository = new UserRepository();
            var productRepository = new ProductRepository();

            // Create a new user
            var user = userFactory.CreateEntity() as User;
            user.Name = "John Doe";
            userRepository.Create(user);

            // Create a new product
            var product = productFactory.CreateEntity() as Product;
            product.Name = "Laptop";
            productRepository.Create(product);

            // Read and display user
            var retrievedUser = userRepository.Read(1) as User;
            Console.WriteLine($"User: {retrievedUser.Name}");

            // Read and display product
            var retrievedProduct = productRepository.Read(1) as Product;
            Console.WriteLine($"Product: {retrievedProduct.Name}");

            // Update user
            retrievedUser.Name = "Jane Doe";
            userRepository.Update(retrievedUser);

            // Update product
            retrievedProduct.Name = "Gaming Laptop";
            productRepository.Update(retrievedProduct);

            // Display updated user and product
            var updatedUser = userRepository.Read(1) as User;
            Console.WriteLine($"Updated User: {updatedUser.Name}");

            var updatedProduct = productRepository.Read(1) as Product;
            Console.WriteLine($"Updated Product: {updatedProduct.Name}");

            // Delete user and product
            userRepository.Delete(1);
            productRepository.Delete(1);

            // Confirm deletion
            var deletedUser = userRepository.Read(1);
            var deletedProduct = productRepository.Read(1);
            Console.WriteLine($"Deleted User: {deletedUser}");
            Console.WriteLine($"Deleted Product: {deletedProduct}");

            Console.ReadKey();

            /*string inputVehicle = null;
            Console.WriteLine("Enter the Vehicle Type:");
            inputVehicle = Console.ReadLine();
            IVehicle vehicle = VehicleFactory.GetVehicle(inputVehicle);
            Console.WriteLine("Vehicle type is " + vehicle.VehicleType());
            Console.WriteLine("Number of wheels " + vehicle.NumberOfWheels());
            Console.ReadKey();*/


        }
    }
}
