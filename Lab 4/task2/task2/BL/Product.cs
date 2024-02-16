using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{

    internal class Product
    {
        public Product(string pname, string pcategory, double pPrice) 
        {
            name = pname;
            category = pcategory;
            price = pPrice;
        }
        public string name;
        public string category;
        public double price;
        public double CalculateTax()
        {
            double tax = 0;
            tax = price * 0.1;
            return tax;
        }
    }
}
