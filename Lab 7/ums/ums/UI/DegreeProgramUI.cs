using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ums
{
    internal class DegreeProgramUI
    {
        public static DegreeProgram AddDegreeProgram()
        {
            Console.Write("Enter Degree Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Degree Duration: ");
            string duration = Console.ReadLine();
            Console.Write("Enter Seats for Degree: ");
            int seats = int.Parse(Console.ReadLine());

            Console.Write("Enter how many Subjects you want to Add: ");
            int count = int.Parse(Console.ReadLine());
            List<Subject> subjects = new List<Subject>();
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter Subject Code: ");
                string code = Console.ReadLine();
                Console.Write("Enter Subject Type: ");
                string type = Console.ReadLine();
                Console.Write("Enter Subject Credit Hours: ");
                int cHours = int.Parse(Console.ReadLine());
                Console.Write("Enter Subject Subject Fees: ");
                double fees = double.Parse(Console.ReadLine());
                Subject s = new Subject(code, type, cHours, fees);
                subjects.Add(s);
            }
            DegreeProgram dp = new DegreeProgram(title, duration, seats, subjects);
            return dp;
        }


        public static void ViewDegreePrograms(List<DegreeProgram> degreePrograms)
        {
            Console.WriteLine("Available Degree Programs");
            foreach (var dp in degreePrograms)
            {
                Console.WriteLine(dp.GetTitle());
            }
        }
    }
}
