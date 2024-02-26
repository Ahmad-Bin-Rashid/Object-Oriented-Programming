using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_app
{
    internal class Product
    {
        public Product(int id, string name, string category, double weight, double stock, double price)
        {
            this.id = id + 1;
            this.name = name;
            this.category = category;
            this.weight = weight;
            this.stock = stock;
            this.price = price;
        }

        public int id = 0;
        public string name;
        public string category;
        public double weight;
        public double stock;
        public double price;
        public int rating;

    }
}
