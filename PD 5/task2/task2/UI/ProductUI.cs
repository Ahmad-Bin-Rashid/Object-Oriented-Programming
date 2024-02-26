using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class ProductUI
    {
        public static Product AddProduct()
        {
            string Name;
            while (true)
            {
                Console.Write("Enter Name of Product: ");
                Name = Console.ReadLine();
                if (!ProductDL.IsValidProduct(Name))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\rProduct Already Exists!");
                }
            }

            Console.Write("Enter Category: ");
            string category = Console.ReadLine();
            Console.Write("Enter Price: ");
            string price = Console.ReadLine();
            Console.Write("Enter Available Stock: ");
            string stock = Console.ReadLine();
            Console.Write("Enter Minimum Stock Threshold Quantity: ");
            string minimum = Console.ReadLine();

            Product product = new Product(Name, category, price, stock, minimum);
            return product;
        }

        public static void ViewProducts(List<Product> products)
        {
            Console.WriteLine("\tName \t\tCategory \t\tPrice \t\tStock \t\tTax \t\tPrice With Tax\n");
            foreach (var p in products)
            {
                Console.WriteLine($"\t{p.GetProductName()} \t\t{p.GetCategory()} \t\tRs{p.GetPrice()} \t\t{p.GetAvailableStock()} \t\tRs{p.GetTax()} \t\tRs{p.GetPriceWithTax()}");
            }
            Console.WriteLine("\n");
        }

        public static string TakeProductName()
        {
            Console.Write("Enter Name of the Product: ");
            string name = Console.ReadLine();
            return name;
        }

        public static void DisplayMaxPriceProduct(Product p)
        {
            Console.WriteLine("\t Name \t\t Category \t\t Price \t\t Stock \t\t Tax\n");
            Console.WriteLine($" ->\t {p.GetProductName()} \t\t {p.GetCategory()} \t\t Rs{p.GetPrice()} \t\t {p.GetAvailableStock()} \t\t Rs{p.GetTax()}");
        }


        public static void ViewProductsTobeOrdered(List<Product> productsTobeOrdered)
        {
            Console.WriteLine("\tName \t\tCategory \t\tPrice \t\tStock \t\tThreshold\n");
            foreach (var p in productsTobeOrdered)
            {
                Console.WriteLine($"\t{p.GetProductName()} \t\t{p.GetCategory()} \t\tRs{p.GetPrice()} \t\t{p.GetAvailableStock()} \t\t{p.GetMinimumStock()}");
            }
        }
    }
}
