using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task2
{
    internal class ConsoleUtility
    {

        public static string LoginMenu()
        {
            cls();
            Console.WriteLine(" Select one of these: \n");
            Console.WriteLine(" 1) SignIn\n");
            Console.WriteLine(" 2) SignUp\n\n");
            Console.WriteLine(" 3) Exit Application\n\n");
            Console.Write(" Enter Your Option (1-3): ");
            string option = Console.ReadLine();
            return option;
        }

        public static string AdminMenu()
        {
            cls();
            string option;
            Console.WriteLine("Select from Following:");
            Console.WriteLine(" 1. Add Product \n");
            Console.WriteLine(" 2. View All Products \n");
            Console.WriteLine(" 3. Find Product with Highest Unit Price \n");
            Console.WriteLine(" 4. View Sales Tax of All Products \n");
            Console.WriteLine(" 5. Products to be Ordered (less than threshold) \n");
            Console.WriteLine(" 6. View Profile (Username, Password) \n");
            Console.WriteLine(" 7. Exit \n");
            Console.Write("Your Option: ");
            option = Console.ReadLine();
            return option;
        }

        public static string CustomerMenu()
        {
            cls();
            string option;
            Console.WriteLine("Select from Following:");
            Console.WriteLine(" 1. View all the products\n");
            Console.WriteLine(" 2. Buy the products\n");
            Console.WriteLine(" 3. Generate invoice\n");
            Console.WriteLine(" 4. View Profile\n");
            Console.WriteLine(" 5. Exit\n");
            Console.Write("Your Option: ");
            option = Console.ReadLine();
            return option;
        }


        public static string getUserName()
        {
            Console.Write("Enter UserName: ");
            string userName = Console.ReadLine();
            return userName;
        }

        public static string getPassword()
        {
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            return password;
        }

        public static string getRole()
        {
            Console.Write("Enter Role ('admin'/ 'customer'): ");
            string role = Console.ReadLine();
            return role;
        }

        public static void cls()
        {
            Console.Clear();
        }

        public static void PressKeyMessage()
        {
            Console.WriteLine("\nPress any key to Continue...");
            Console.ReadKey();
        }

        public static void DisplayInvalid()
        {
            Console.WriteLine("Invalid Input!");
            Thread.Sleep(800);
        }
    }
}
