using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge2
{
    internal class Product
    {
        public string id;
        public string name;
        public double price;
        public string category;
        public string brandName;
        public string country;

        public Product(string id, string name, double price, string category, string brandName, string country)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.category = category;
            this.brandName = brandName;
            this.country = country;
        }

        public string DisplayProducts () 
        {
            return $"\tID: {id}\tName: {name}\tPrice: Rs {price}\tCategory: {category}\tBrand Name: {brandName}\tCountry: {country}";
        }
    }
}
