using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task2
{

    internal class Customer
    {
        public Customer(string cname, string cAddress, string cContact)
        {
            name = cname;
            address = cAddress;
            contact = cContact;
        }
        public string name;
        public string address;
        public string contact;
        public  List<Product> products = new List<Product>();
        public List<Product> getAllProducts()
        {
            return products;
        }
        public void addProduct (Product p)
        {
            products.Add(p);
        }
    }


}
