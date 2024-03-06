using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUp_Week6_
{
    class MUserUI
    {
        public static int menu()
        {
            int option;
            Console.WriteLine("1. SignIn");
            Console.WriteLine("2. SignUp");
            Console.WriteLine("Enter Option");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        public static void printList(List<MUser> usersList)
        {
            foreach (MUser storedUser in usersList)
            {
                Console.WriteLine(storedUser.getUserName() + " " + storedUser.getUserPassword());
            }
        }

        public static MUser TakeInputFromConsole()
        {
            Console.WriteLine("Enter UserName");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter UserPassword");
            string userPassword = Console.ReadLine();
            Console.WriteLine("Enter UserRole");
            string userRole = Console.ReadLine();

            MUser user = new MUser(userName, userPassword, userRole);
            return user;

        }

        public static MUser takeInputwithOutRole()
        {
            Console.WriteLine("Enter UserName");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter UserPassword");
            string userPassword = Console.ReadLine();
            MUser user = new MUser(userName, userPassword);
            return user;
        }
    }
}
