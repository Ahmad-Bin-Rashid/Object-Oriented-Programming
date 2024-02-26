using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_app
{
    internal class Vehicle
    {
        public Vehicle(int id, string name, string category, string make, string model, string color, double stock, double price)
        {
            this.id = id+1;
            this.name = name;
            this.category = category;
            this.make = make;
            this.model = model;
            this.color = color;
            this.stock = stock;
            this.price = price;
        }
        public int id;
        public string name;
        public string category;
        public string make;
        public string model;
        public string color;
        public double stock;
        public double price;
        public int rating;

    }
}
