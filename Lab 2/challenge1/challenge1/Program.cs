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
            List<Student> stu = new List<Student>();
            while (true)
            {
                string option = Menu();

                switch (option)
                {
                    case "1":

                    case "2":

                    case "3":

                    case "4":

                    case "5":
                        return;
                    default:
                        Console.WriteLine("\n\t Please Enter Valid Option!");
                        Console.ReadKey();
                        continue;
                }
            }
        }

        static string Menu() 
        {
            string option = "";
            Console.WriteLine("\t\t\t\t ***(   STUDENT MANAGEMENT SYSTEM   )***\n\n");
            Console.WriteLine("\t Select from following:-\n");
            Console.WriteLine("\t\t 1) Add Student");
            Console.WriteLine("\t\t 2) Show Student");
            Console.WriteLine("\t\t 3) Calculate Aggregate");
            Console.WriteLine("\t\t 4) Top Student\n");
            Console.WriteLine("\t\t 5) Exit Program");
            Console.Write("\t Your Option: ");
            option = Console.ReadLine();
            return option;
        } 


        //static 
        //{
        //    Student[] studentData = new Student[5];
        //    for (int x = 0; x< 5; x++)
        //    {
        //        studentData[x] = TakeStudentInput();
        //    }
        //    PrintStudentData(studentData);
        //    Console.ReadKey();
        //        }

        static Student TakeStudentInput()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Student Matric Marks: ");
            float matricMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Student Fsc Marks: ");
            float fscMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Student Ecat Marks: ");
            float ecatMarks = float.Parse(Console.ReadLine());
            Student s = new Student(name, matricMarks, fscMarks, ecatMarks);
            return s;
        }

    }
}
