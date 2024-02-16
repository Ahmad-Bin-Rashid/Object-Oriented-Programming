using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaizanTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Putabaaz> person = new List<Putabaaz>();
            while (true)
            {
                Console.Clear();
                string option = Menu();
                switch (option)
                {
                    case "1":
                        person.Add(AddPerson(person));
                        break;
                    case "2":
                        PrintStudentData(person);
                        Console.ReadKey();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("\n\t Please Enter Valid Option!");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static string Menu()
        {
            string option = "";
            Console.WriteLine("\nSelect from following:-");
            Console.WriteLine(" 1) Add person");
            Console.WriteLine(" 2) Show all");
            Console.WriteLine(" 3) Exit Program");
            Console.Write("Your Option: ");
            option = Console.ReadLine();
            return option;
        }

        static Putabaaz AddPerson(List<Putabaaz> person)
        {
            Console.Clear();
            Console.Write("Enter person Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter person Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter person gender( M / F ): ");
            char gender = char.Parse(Console.ReadLine());
            if (person.Count == 0)
            {
                Putabaaz p = new Putabaaz(name, age, gender);
                return p;
            }
            else
            {
                Putabaaz p = new Putabaaz(name, age, gender, person[person.Count -1].id);
                return p;
            }
        }

        static void PrintStudentData(List<Putabaaz> person)
        {
            Console.Clear();
            Console.WriteLine("Name \t Age \t Gender \t ID");
            for (int x = 0; x < person.Count; x++)
            {
                Console.WriteLine(person[x].name + "\t" + person[x].age + "\t" + person[x].gender + "\t" + person[x].id);
            }
        }
    }
}
