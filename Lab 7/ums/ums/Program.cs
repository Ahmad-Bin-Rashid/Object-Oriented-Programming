using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option;
            string connectionString = "Server = AHMAD-HP; Database = UMS; Trusted_Connection = True;";

            while (true)
            {
                ConsoleUtility.cls();
                option = ConsoleUtility.MainMenu();
                if (option == "1")
                {
                    Student s = StudentUI.AddStudent();
                    bool check = StudentDL.AddStudent(s, connectionString);
                    ConsoleUtility.PrintMessage($"{check}");
                    ConsoleUtility.PressKeyMessage();
                }
                else if (option == "2")
                {

                }
                else if (option == "3")
                {

                }
                else if (option == "4")
                {

                }
                else if (option == "5")
                {

                }
                else if (option == "6")
                {

                }
                else if (option == "7")
                {

                }
                else if (option == "8")
                {

                }
                else
                {
                    ConsoleUtility.DisplayInvalid();
                }

            }
        }
    }
}
