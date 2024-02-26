using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task2
{
    internal class ProductDL
    {
        public static List<Product> productList = new List<Product>();
        public static List<Product> productsTobeOrdered = null;

        public static List<Product> GetList()
        {
            return productList;
        }

        public static void AddProduct(Product product)
        {
            productList.Add(product);
        }

        public static bool IsValidProduct(string name)
        {
            foreach (var product in productList)
            {
                if (product.GetProductName() == name)
                {
                    return true;
                }
            }
            return false;
        }

        public static Product GetProduct(string name)
        {
            foreach (var p in productList)
            {
                if (p.GetProductName() == name)
                {
                    return p;
                }
            }
            return null;
        }

        public static Product FindMaxPriceProduct()
        {
            double max = 0;
            Product product = null;
            foreach (var p in productList)
            {
                if (double.Parse(p.GetPrice()) > max)
                {
                    max = double.Parse(p.GetPrice());
                    product = p;
                }
            }
            return product;
        }

        public static List<Product> FindProductsTobeOrdered()
        {
            productsTobeOrdered = new List<Product>();
            foreach (var p in productList)
            {
                if (p.GetAvailableStock() <= p.GetMinimumStock())
                {
                    productsTobeOrdered.Add(p);
                }
            }
            return productsTobeOrdered;
        }

        public static void CalculatePriceWithTax()
        {
            double price = 0;
            foreach (var p in productList)
            {
                price = double.Parse(p.GetPrice()) + p.GetTax();
                p.SetPriceWithTax($"{price}"); 
            }
        }

        public static void ReadFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;

            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedrecord = record.Split(',');

                    string name = splittedrecord[0];
                    string category = splittedrecord[1];
                    string price = splittedrecord[2];
                    string stock = splittedrecord[3];
                    string minimum = splittedrecord[4];
                    string priceWithTax = splittedrecord[5];

                    Product product = new Product(name, category, price, stock, minimum, priceWithTax);
                    productList.Add(product);
                }
                f.Close();
            }
        }

        public static void WriteToFile(string path)
        {
            StreamWriter f = new StreamWriter(path);
            foreach (var p in productList)
            {
                f.WriteLine(p.GetProductName() + "," + p.GetCategory() + "," + p.GetPrice() + "," + p.GetAvailableStock() + "," + p.GetMinimumStock() + "," + p.GetPriceWithTax());
            }
            f.Flush();
            f.Close();
        }
    }
}
