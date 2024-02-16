using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Product product1 = new Product("Laptop", "Electronics", 1200.00);
                Product product2 = new Product("Book", "Literature", 20.50);

                Customer customer = new Customer("John Doe", "123 Main St", "123-456-7890");

                customer.addProduct(product1);
                customer.addProduct(product2);

                List<Product> customerProducts = customer.getAllProducts();

                Console.WriteLine($"Customer: {customer.name}");
                Console.WriteLine($"Address: {customer.address}");
                Console.WriteLine($"Contact: {customer.contact}");

                Console.WriteLine("\nProducts:");
                foreach (var product in customerProducts)
                {
                    Console.WriteLine($"- {product.name}, Category: {product.category}, Price: Rs{product.price}, Tax: Rs{product.CalculateTax()}");
                }
                Console.ReadKey();
            }
        }
    }
}
