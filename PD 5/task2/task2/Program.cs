using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option1;
            string option2;
            string username;
            string password;
            string role;
            bool validAdmin;
            bool validCustomer = false;
            bool check;
            string productName;
            string adminFilePath = "admins.txt";
            string customerFilePath = "customers.txt";
            string productFilePath = "products.txt";

            AdminDL.ReadFromFile(adminFilePath);
            CustomerDL.ReadFromFile(customerFilePath);
            ProductDL.ReadFromFile(productFilePath);

            while (true)
            {
                ConsoleUtility.cls();
                option1 = ConsoleUtility.LoginMenu();

                if (option1 == "1")
                {
                    username = ConsoleUtility.getUserName();
                    password = ConsoleUtility.getPassword();
                    validAdmin = AdminDL.CheckAdmin(username, password);
                    if (!validAdmin)
                    {
                        validCustomer = CustomerDL.CheckCustomer(username, password);
                    }

                    if (validAdmin || validCustomer)
                    {
                        if (validAdmin)
                        {
                            Admin activeAdmin = AdminDL.GetAdmin(username);
                            while (true)
                            {
                                ConsoleUtility.cls();
                                option2 = ConsoleUtility.AdminMenu();

                                if (option2 == "1")
                                {
                                    Product p = ProductUI.AddProduct();
                                    ProductDL.AddProduct(p);
                                    ProductDL.CalculatePriceWithTax();
                                    ProductDL.WriteToFile(productFilePath);
                                    ConsoleUtility.PressKeyMessage();
                                }
                                else if (option2 == "2")
                                {
                                    ConsoleUtility.cls();
                                    ProductUI.ViewProducts(ProductDL.GetList());
                                    ConsoleUtility.PressKeyMessage();
                                }
                                else if (option2 == "3")
                                {
                                    ProductUI.DisplayMaxPriceProduct(ProductDL.FindMaxPriceProduct());
                                    ConsoleUtility.PressKeyMessage();
                                }
                                else if (option2 == "4")
                                {
                                    ConsoleUtility.cls();
                                    ProductUI.ViewProducts(ProductDL.GetList());
                                    ConsoleUtility.PressKeyMessage();
                                }
                                else if (option2 == "5")
                                {
                                    ConsoleUtility.cls();
                                    ProductUI.ViewProductsTobeOrdered(ProductDL.FindProductsTobeOrdered());
                                    ConsoleUtility.PressKeyMessage();
                                }
                                else if (option2 == "6")
                                {
                                    AdminUI.ViewAdminProfile(activeAdmin);
                                    ConsoleUtility.PressKeyMessage();
                                }
                                else if (option2 == "7")
                                {
                                    break;
                                }
                                else
                                {
                                    ConsoleUtility.DisplayInvalid();
                                }
                            }

                        }
                        else if (validCustomer)
                        {
                            Customer activeCustomer = CustomerDL.GetCustomer(username);
                            while (true)
                            {
                                ConsoleUtility.cls();
                                option2 = ConsoleUtility.CustomerMenu();

                                if (option2 == "1")
                                {
                                    ConsoleUtility.cls();
                                    ProductUI.ViewProducts(ProductDL.GetList());
                                    ConsoleUtility.PressKeyMessage();
                                }
                                else if (option2 == "2")
                                {
                                    ConsoleUtility.cls();
                                    ProductUI.ViewProducts(ProductDL.GetList());
                                    productName = ProductUI.TakeProductName();
                                    check = ProductDL.IsValidProduct(productName);
                                    if (check)
                                    {
                                        activeCustomer.BuyProduct(ProductDL.GetProduct(productName));
                                        CustomerDL.WriteToFile(customerFilePath);
                                        ProductDL.WriteToFile(productFilePath);
                                        ConsoleUtility.PressKeyMessage();
                                    }
                                    else
                                    {
                                        ConsoleUtility.DisplayInvalid();
                                    }
                                }
                                else if (option2 == "3")
                                {
                                    ConsoleUtility.cls();
                                    ProductUI.ViewProducts(activeCustomer.GetBoughtProductList());
                                    ProductDL.CalculatePriceWithTax();
                                    CustomerUI.DisplayInvoice(activeCustomer.GenerateInvoice());
                                    ConsoleUtility.PressKeyMessage();
                                }
                                else if (option2 == "4")
                                {
                                    CustomerUI.ViewCustomerProfile(activeCustomer);
                                    ConsoleUtility.PressKeyMessage();
                                }
                                else if (option2 == "5")
                                {
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        ConsoleUtility.DisplayInvalid();
                    }
                }
                else if (option1 == "2")
                {
                    role = ConsoleUtility.getRole();
                    if (role == "admin")
                    {
                        Admin admin = AdminUI.AddAdmin();
                        AdminDL.AddAdmin(admin);
                        AdminDL.WriteToFile(adminFilePath);
                        ConsoleUtility.PressKeyMessage();
                    }
                    else if (role == "customer")
                    {
                        Customer customer = CustomerUI.AddCustomer();
                        CustomerDL.AddCustomer(customer);
                        CustomerDL.WriteToFile(customerFilePath);
                        ConsoleUtility.PressKeyMessage();
                    }
                    else
                    {
                        ConsoleUtility.DisplayInvalid();
                    }
                }
                else if (option1 == "3")
                {
                    AdminDL.WriteToFile(adminFilePath);
                    CustomerDL.WriteToFile(customerFilePath);
                    ProductDL.WriteToFile(productFilePath);
                    return;
                }
                else
                {
                    ConsoleUtility.DisplayInvalid();    
                }
            }
        }
    }

}
