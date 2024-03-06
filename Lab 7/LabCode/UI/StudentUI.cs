using Labwork.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork.UI
{
    internal class StudentUI
    {
        public  static Student GetStudentFromUser()
        {
            Console.WriteLine("Enter Student Roll");
            int roll = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter ECAT Marks ");
            float ecat = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fsc Marks ");
            float fsc = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Matric Marks ");
            float matric = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of prefrences ");
            int pref = int.Parse(Console.ReadLine());
            List<DegreeProgram> prefernces = new List<DegreeProgram>();
            for (int i = 0; i  < pref; i++)
            {
                Console.WriteLine("Enter your Prefrences "+(i+1));
                string yourpref = Console.ReadLine();

                //you have to check this degree program in the database 

                DegreeProgram subject = new DegreeProgram();
                subject.Title = yourpref;
                prefernces.Add(subject);
            }

            Student student = new Student(roll, name, ecat, fsc, matric);
            student.Prefrences = prefernces;
            return student;
        }
    }
}
