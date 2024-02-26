using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class CustomerUI
    {

        public static Customer AddCustomer()
        {
            string userName;
            while (true)
            {
                Console.Write("Enter UserName: ");
                userName = Console.ReadLine();
                if (CustomerDL.IsValidCustomer(userName))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\rUserName Already Exists. Try some other...");
                }
            }

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            Console.Write("Enter your Name: ");
            string email = Console.ReadLine();
            Console.Write("Enter your Phone Number: ");
            string number = Console.ReadLine();
            Console.Write("Enter your Address: ");
            string address = Console.ReadLine();

            Customer customer = new Customer(userName, password, email, number, address);
            return customer;
        }

        public static void ViewCustomerProfile(Customer c)
        {
            Console.WriteLine("\tUsername\t\t Password\t\t Email\t\t Number\t\t Address\n");
            Console.WriteLine($"\t{c.GetUsername()}\t\t {c.GetPassword()}\t\t {c.GetEmail()}\t\t {c.GetNumber()}\t\t {c.GetAddress()}");
        }

        public static void DisplayInvoice(double total)
        {
            Console.WriteLine($"\n\tTotal Price: \t\tRs {total}");
        }
    }
}
