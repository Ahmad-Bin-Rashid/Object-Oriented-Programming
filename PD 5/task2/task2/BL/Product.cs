using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Product
    {
        public string name;
        public string category;
        public string price;
        public string availableStock;
        public string minimumStock;
        public string priceWithTax;

        public Product(string name, string category, string price, string availableStock, string minimumStock)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.availableStock = availableStock;
            this.minimumStock = minimumStock;
            this.priceWithTax = price;
        }

        public Product(string name, string category, string price, string availableStock, string minimumStock, string priceWithTax)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.availableStock = availableStock;
            this.minimumStock = minimumStock;
            this.priceWithTax = priceWithTax;
        }

        public string GetProductName()
        {
            return this.name;
        }
        public string GetCategory()
        {
            return this.category;
        }
        public string GetPrice()
        {
            return this.price;
        }
        public double GetAvailableStock()
        {
            return double.Parse(this.availableStock);
        }

        public void DecreaseStock()
        {
            this.availableStock = $"{double.Parse(this.availableStock) - 1}";
        }
        public double GetMinimumStock()
        {
            return double.Parse(this.minimumStock);
        }

        public double GetPriceWithTax()
        {
            return double.Parse(this.priceWithTax);
        }

        public void SetPriceWithTax(string price)
        {
            this.priceWithTax = price;
        }

        public double GetTax()
        {
            double tax;
            if (this.category == "grocery")
            {
                tax = double.Parse(this.price) * 0.1;
            } 
            else if (this.category == "fruit")
            {
                tax = double.Parse(this.price) * 0.05;
            }
            else
            {
                tax = double.Parse(this.price) * 0.15;
            }
            return tax;
        }
    }
}
