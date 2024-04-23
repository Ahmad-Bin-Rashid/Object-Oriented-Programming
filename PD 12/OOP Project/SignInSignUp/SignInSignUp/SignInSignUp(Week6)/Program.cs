using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICoreBL.Generic;
using ICoreBL;
using ICoreBL.DL;
namespace SignInSignUp_Week6_
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Data.txt";
            string constring = "";
            IMUserStore iStore,bStore;
            iStore = MUserFileStore.getInstance(path);
            bStore = MUserFileStore.getInstance(path);
            bStore = new MuserDBStore(constring);
            // MUserCRUD.readDataFromFile(path);
            int option = 0;
            while (option != 3)
            {
                Console.Clear();
                option = MUserUI.menu();
                if (option == 1)
                {
                    MUser user = MUserUI.takeInputwithOutRole();
                    user = iStore.SignIn(user);
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
                }
                else if (option == 2)
                {
                    MUser user = MUserUI.TakeInputFromConsole();
                    bStore.SignUp(user);
                  //  MUserCRUD.storeUserIntoFile(user, path);
                }
                else  if (option == 3)
                {
                    MUserUI.printList(iStore.getAllUsers());


                }
                Console.ReadKey();
            }
        }
        


    }
}
