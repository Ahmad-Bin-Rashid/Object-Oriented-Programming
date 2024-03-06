using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ums
{
    internal class ConsoleUtility
    {
        public static string MainMenu()
        {
            Console.WriteLine("Select from Following:");
            Console.WriteLine(" 1. Add Student \n");
            Console.WriteLine(" 2. Add Degree Program \n");
            Console.WriteLine(" 3. Generate Merit \n");
            Console.WriteLine(" 4. View Registered Subjects \n");
            Console.WriteLine(" 5. View Student of a Specific Program \n");
            Console.WriteLine(" 6. Register Subject for a Specific Student \n");
            Console.WriteLine(" 7. Calculate Fees for all Registered Students \n");
            Console.WriteLine(" 8. Exit \n");
            Console.Write("Your Option: ");
            string option = Console.ReadLine();
            return option;
        }

        public static void cls()
        {
            Console.Clear();
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine($"\n{message}");
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
