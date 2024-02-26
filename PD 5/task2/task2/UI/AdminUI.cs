using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class AdminUI
    {
        public static Admin AddAdmin()
        {
            string userName;
            while (true)
            {
                Console.Write("Enter UserName: ");
                userName = Console.ReadLine();
                if (AdminDL.IsValidAdmin(userName))
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

            Admin admin = new Admin(userName, password);
            return admin;
        }

        public static void ViewAdminProfile(Admin admin) 
        {
            Console.WriteLine("\tUsername \t\t Password\n");
            Console.WriteLine($"\t{admin.GetUsername()} \t\t {admin.GetPassword()}");
        }
    }
}
