using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            double storeWorth = 0.0;

            while (true)
            {
                string option = Menu();
                switch (option)
                {
                    case "1":
                        products.Add(AddProduct());
                        Console.WriteLine("New Product Added successfully...");
                        Console.ReadKey();
                        break;
                    case "2":
                        ShowProducts(products);
                        Console.ReadKey();
                        break;

                    case "3":
                        storeWorth = CalculateTotal(products);
                        TotalWorth(storeWorth);
                        Console.ReadKey();
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Invalid Input!");
                        Console.ReadKey();
                        break;

                }
            }

        }

        static string Menu()
        {
            Console.Clear();
            Console.WriteLine("Select from following: ");
            Console.WriteLine("1) Add Product");
            Console.WriteLine("2) Show Products");
            Console.WriteLine("3) Total Store Worth");
            Console.WriteLine("4) Exit");
            Console.Write("Your Option: ");
            string option = Console.ReadLine();
            return option;
        }

        static Product AddProduct()
        {
            Console.Clear();
            Console.Write("Enter the ID of student: ");
            string id = Console.ReadLine();
            Console.Write("Enter the name of student: ");
            string name = Console.ReadLine();
            Console.Write("Enter price of Product: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Enter Category of the Product: ");
            string category = Console.ReadLine();
            Console.Write("Enter Brand Name of the Prduct: ");
            string brand = Console.ReadLine();
            Console.Write("Enter the Country of Product: ");
            string country = Console.ReadLine();
            Product p = new Product(id, name, price, category, brand, country);
            return p;
        }

        static void ShowProducts(List<Product> products)
        {
            Console.Clear();
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(i + 1 + ") "+ products[i].DisplayProducts());
            }
        }

        static double CalculateTotal(List<Product> products)
        {
            double total = 0;
            for (int i = 0; i < products.Count; i++)
            {
                total += products[i].price;
            }
            return total;
        }

        static void TotalWorth(double total)
        {
            Console.Clear();
            Console.WriteLine("\nTotal Store Worth: "+ total);
        }
    }
}
