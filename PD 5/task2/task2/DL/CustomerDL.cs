using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class CustomerDL
    {
        public static List<Customer> customerList = new List<Customer>();

        public static void AddCustomer(Customer customer)
        {
            customerList.Add(customer);
        }

        public static List<Customer> GetList()
        {
            return customerList;
        }

        public static bool IsValidCustomer(string userName)
        {
            foreach (var customer in customerList)
            {
                if (customer.GetUsername() == userName)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckCustomer(string userName, string password)
        {
            foreach (var user in customerList)
            {
                if (user.GetUsername() == userName && user.GetPassword() == password)
                {
                    return true;
                }
            }
            return false;
        }

        public static string CheckRole(string userName)
        {
            string role = null;
            foreach (var user in customerList)
            {
                if (user.GetUsername() == userName)
                {
                    role = user.GetRole();
                }

            }
            return role;
        }

        public static Customer GetCustomer(string userName)
        {
            foreach (var user in customerList)
            {
                if (user.GetUsername() == userName)
                {
                    return user;
                }
            }
            return null;
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

                    string username = splittedrecord[0];
                    string password = splittedrecord[1];
                    string email = splittedrecord[2];
                    string number = splittedrecord[3];
                    string address = splittedrecord[4];

                    string[] splittedBoughtProducts = splittedrecord[5].Split(';');

                    List<Product> productsBought = new List<Product>();

                    for (int i = 0; i < splittedBoughtProducts.Length; i++)
                    {
                        Product p = ProductDL.GetProduct(splittedBoughtProducts[i]);

                        if (p != null)
                        {
                            if (!(productsBought.Contains(p)))
                            {
                                productsBought.Add(p);
                            }
                        }

                    }

                    Customer customer = new Customer(username, password, email, number, address, productsBought);
                    customerList.Add(customer);
                }
                f.Close();
            }
        }

        public static void WriteToFile(string path)
        {
            StreamWriter f = new StreamWriter(path);
            string boughtProductNames = "";

            foreach (var c in customerList)
            {
                if (c.GetBoughtProductList().Count > 0)
                {
                    for (int x = 0; x < c.GetBoughtProductList().Count - 1; x++)
                    {
                        boughtProductNames += (c.GetBoughtProductList()[x].GetProductName() + ";");
                    }
                    boughtProductNames += c.GetBoughtProductList()[c.GetBoughtProductList().Count-1].GetProductName();
                }
                f.WriteLine(c.GetUsername() + "," + c.GetPassword() + "," + c.GetEmail() + "," + c.GetNumber() + "," + c.GetAddress() + "," + boughtProductNames);
            }
            f.Flush();
            f.Close();
        }
    }
}
