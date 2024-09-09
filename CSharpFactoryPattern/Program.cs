using CSharpFactoryPattern.FactoryPattern;
using CSharpFactoryPattern.Repository;
using System;
using System.Collections.Generic;
using System.Data;
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
            var productFactory = new ProductFactory();

            // Create repositories
            var productRepository = new ProductRepository();

            AddCommand();
            bool isRunning = true;
            while (isRunning)
            {
                try 
                {
                    var command = Console.ReadLine().ToLower();
                    if (command == "c")
                    {
                        AddCommand();
                    }
                    else if (command == "x")
                    {
                        isRunning = false;
                    }
                    else if (command == "rp")
                    {
                        Console.WriteLine("Type a product id");
                        var id = Convert.ToInt32(Console.ReadLine());
                        // Read and display product
                        var retrievedProduct = productRepository.Read(id) as Product;
                        Console.WriteLine($"Product: {retrievedProduct.Name}");
                    }
                    else if (command == "cp")
                    {
                        Console.WriteLine("Type a product name");
                        var name = Console.ReadLine();
                        // Create a new product
                        var product = productFactory.CreateEntity() as Product;
                        product.Name = name;
                        productRepository.Create(product);
                    }
                    else if (command == "up")
                    {
                        Console.WriteLine("Type a product id");
                        var id = Convert.ToInt32(Console.ReadLine());
                        var updatedProduct = productRepository.Read(1) as Product;
                        Console.WriteLine($"Updated Product: {updatedProduct.Name}");

                        Console.WriteLine("Type a product name to update");
                        var name = Console.ReadLine();
                        // Update product
                        updatedProduct.Name = name;
                        productRepository.Update(updatedProduct);
                    }
                    else if (command == "dp")
                    {
                        Console.WriteLine("Type a product id");
                        var id = Convert.ToInt32(Console.ReadLine());

                        // Confirm deletion
                        var deletedProduct = productRepository.Read(id);
                        Console.WriteLine($"Deleted Product: {deletedProduct.Name}");
                        productRepository.Delete(id);
                    }
                }
                catch { }
            }
        }

        static void AddCommand()
        {
            Console.WriteLine("Press 'RP' for read a product");
            Console.WriteLine("Press 'CP' for creation of product");
            Console.WriteLine("Press 'UP' for update of product");
            Console.WriteLine("Press 'DP' for deletion of product");
            Console.WriteLine("Press 'C' for clear window and 'X' for exit");
        }
    }
}
