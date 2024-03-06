using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class StudentUI
    {

        public static Student AddStudent()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Student age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Fsc Marks: ");
            float fsc = float.Parse(Console.ReadLine());
            Console.Write("Enter Student Ecat Marks: ");
            float ecat = float.Parse(Console.ReadLine());
            Student s = new Student(name, age, fsc, ecat);
            return s;
        }

        public static List<DegreeProgram> AddPreferences(List<DegreeProgram> degreePrograms)
        {
            Console.Write("Enter how many Degree Programs to Add in Preferences: ");
            int count = int.Parse(Console.ReadLine());
            List<DegreeProgram> prefer = new List<DegreeProgram>();
            for (int i = 0; i < count; i++)
            {
                string title = Console.ReadLine();
                foreach (var dp in degreePrograms)
                {
                    if (title == dp.GetTitle())
                    {
                        prefer.Add(dp);
                    }
                }
            }
            return prefer;
        }

        public static void GenerateMerit(List<Student> studentList, List<DegreeProgram> degreePrograms)
        {
            foreach (var s in studentList)
            {
                foreach (var prefer in s.GetPreferences())
                {
                    foreach (var dp in degreePrograms)
                    {
                        if (prefer.GetTitle() == dp.GetTitle())
                        {
                            s.SetEnrolledDegree(dp);
                            Console.WriteLine($"{s.GetName()} got addmission in {s.GetEnrolledDegree()}");
                        }
                    }
                }
            }
        }
    }
}
