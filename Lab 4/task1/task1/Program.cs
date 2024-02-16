using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ali", 105, 1011, 990, 250, "Lahore", false);
            Student s2 = new Student("Salman", 94, 1003, 940, 267, "Sahiwal", true);
            string option = "";
            while (true)
            {
                option = Menu();
                if (option == "1")
                {
                    Console.WriteLine($"\tName \t\t Rollno \t\t HomeTown \t\t Hostelite");
                    Console.WriteLine($"\t{s1.name} \t\t {s1.rollno} \t\t {s1.homeTown} \t\t {s1.isHostelite}");
                    Console.WriteLine($"\t{s2.name} \t\t {s2.rollno} \t\t {s2.homeTown} \t\t {s2.isHostelite}");
                    Console.ReadKey();

                }
                else if (option == "2")
                {
                    Console.WriteLine($"\tName \t\t Merit");
                    Console.WriteLine($"\t{s1.name} \t\t {s1.CalculateMerit()}");
                    Console.WriteLine($"\t{s2.name} \t\t {s2.CalculateMerit()}");
                    Console.ReadKey();

                }
                else if (option == "3")
                {
                    Console.WriteLine($"\tName \t\t Scholarship Status");
                    Console.WriteLine($"\t{s1.name} \t\t {s1.isEligibleforScholarship()}");
                    Console.WriteLine($"\t{s2.name} \t\t {s2.isEligibleforScholarship()}");
                    Console.ReadKey();

                }
                else if (option == "4")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                    Console.ReadKey();
                }
            }
        }

        static string Menu()
        {
            string option;
            Console.WriteLine("Selet from following: ");
            Console.WriteLine("1) Show Students");
            Console.WriteLine("2) Show Merit");
            Console.WriteLine("3) Show Scholarship Status");
            Console.WriteLine("4) Exit");
            Console.Write("Your Option: ");
            option = Console.ReadLine();
            return option;
        }
    }
}
