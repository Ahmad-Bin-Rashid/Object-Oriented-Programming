using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string[] topStudents = new string[3];

            while(true)
            {
                string option = Menu();
                switch (option)
                {
                    case "1":
                        students.Add(AddStudent());
                        Console.WriteLine("New Student Added successfully...");
                        Console.ReadKey();
                        break;
                    case "2":
                        ShowStudents(students);
                        Console.ReadKey();
                        break;

                    case "3":
                        AggregateCalculation(students);
                        Console.WriteLine("Aggregate Calculated Successfully!");
                        Console.ReadKey();
                        break;

                    case "4":
                        TopStudentSearch(students, topStudents);
                        DisplayTop(topStudents);
                        Console.ReadKey();
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Invalid Input!");
                        Console.ReadKey();
                        break;

                }
            }

        }

        static string Menu()
        {
            Console.Clear();
            Console.WriteLine("Select from following: ");
            Console.WriteLine("1) Add Student");
            Console.WriteLine("2) Show Students");
            Console.WriteLine("3) Calculate Aggregate");
            Console.WriteLine("4) Top Students");
            Console.WriteLine("5) Exit");
            Console.Write("Your Option: ");
            string option = Console.ReadLine();
            return option;
        }

        static Student AddStudent()
        {
            Console.Clear();
            Console.Write("Enter the name of student: ");
            string name = Console.ReadLine();
            Console.Write("Enter Matric Marks: ");
            double matric = double.Parse(Console.ReadLine());
            Console.Write("Enter Fsc Marks: ");
            double fsc = double.Parse(Console.ReadLine());
            Console.Write("Enter Ecat Marks: ");
            double ecat = double.Parse(Console.ReadLine());
            Student s = new Student(name, matric, fsc, ecat);
            return s;
        }

        static void ShowStudents(List<Student> students)
        {
            Console.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(i + 1 +")\t\tName: "+ students[i].name +"\t\tAggreagate: "+ students[i].aggregate);
            }
        }

        static void AggregateCalculation (List<Student> students)
        {
            Console.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                students[i].CalculateAggregate();
            }
        }

        static void TopStudentSearch (List<Student> students, string[] topStudents)
        {
            double largest = 0;
            string name = "";
            for (int i = 0; i < 3; i++)
            {
                foreach (Student student in students)
                {
                    if (student.aggregate > largest && student.name != topStudents[0] && student.name != topStudents[1] && student.name != topStudents[2])
                    {
                        largest = student.aggregate;
                        name = student.name;
                    }
                }
                topStudents[i] = name;
                largest = 0;
            }
        }

        static void DisplayTop(string[] topStudents)
        {
            Console.Clear();
            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine(x+1 + ")  "+ topStudents[x]);
            }
        }
    }
}
