using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Customer
    {
        public string Username;
        public string Password;
        public string Role;
        public string Email;
        public string Address;
        public string Number;
        public List<Product> productsBought;

        public Customer(string username, string password, string email, string number, string address)
        {
            this.Username = username;
            this.Password = password;
            this.Role = "customer";
            this.Email = email;
            this.Number = number;
            this.Address = address;
            this.productsBought = new List<Product>();
        }

        public Customer(string username, string password, string email, string number, string address, List<Product> productsBought)
        {
            this.Username = username;
            this.Password = password;
            this.Role = "customer";
            this.Email = email;
            this.Number = number;
            this.Address = address;
            this.productsBought = productsBought;
        }

        public string GetUsername()
        {
            return this.Username;
        }
        public string GetPassword()
        {
            return this.Password;
        }
        public string GetRole()
        {
            return this.Role;
        }
        public string GetEmail()
        {
            return this.Email;
        }
        public string GetNumber()
        {
            return this.Number;
        }
        public string GetAddress()
        {
            return this.Address;
        }

        public void BuyProduct(Product p)
        {
            this.productsBought.Add(p);
            p.DecreaseStock();
        }

        public List<Product> GetBoughtProductList()
        {
            return this.productsBought;
        }

        public double GenerateInvoice()
        {
            double total = 0;
            foreach (var p in this.productsBought)
            {
                total += p.GetPriceWithTax();
            }
            return total;
        }
    }
}
