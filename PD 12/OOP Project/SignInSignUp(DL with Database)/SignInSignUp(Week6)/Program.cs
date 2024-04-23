using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUp_Week6_
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            
            string connectionSting = "Server=LAPTOP-285-180\\SQLEXPRESS;Database=EnterUserApplication;Trusted_Connection=True;";
            
            
            while (option != 3)
            {
                Console.Clear();
                option = MUserUI.menu();
                if (option == 1)
                {
                    MUser user = MUserUI.takeInputwithOutRole();
                    user = MUserCRUD.SignIn(user, connectionSting);
                    if (user != null)
                    {
                        if (user.isAdmin())
                        {
                            Console.WriteLine("This is Admin");
                            //Admin Menu
                        }
                        else
                        {
                            Console.WriteLine("This is User");
                            //User Menu
                        }
                    }
                    else
                    {
                        Console.WriteLine("User is not Valid");
                    }
                }
                else if (option == 2)
                {
                    MUser user = MUserUI.TakeInputFromConsole();

                    if (MUserCRUD.storeUserIntoDb(user, connectionSting))
                    {
                        Console.WriteLine("User Added");
                    }
                    else
                    {
                        Console.WriteLine("User not Added");
                    }
                }
                Console.ReadKey();
            }
        }
        


    }
}
