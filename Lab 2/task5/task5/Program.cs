using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] studentData = new Student[5];
            for (int x = 0; x < 5; x++)
            {
                studentData[x] = TakeStudentInput();
            }
            PrintStudentData(studentData);
            Console.ReadKey();
        }

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

        static void PrintStudentData(Student[] studentData)
        {
            Console.WriteLine("Name \t MatricMarks \t FscMarks \t EcatMarks \t Aggregate");
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine(studentData[x].sname + "\t" + studentData[x].matricMarks + "\t" + studentData[x].fscMarks + "\t" + studentData[x].ecatMarks + "\t" + studentData[x].aggregate);
            }
        }
    }
}
