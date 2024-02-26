using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class DegreeProgram
    {
        public string title;
        public string duration;
        public int seats;

        public List<Subject> degreeSubjects;
    
        public DegreeProgram(string title, string duration, int seats)
        {
            this.title = title;
            this.duration = duration;
            this.seats = seats;
            this.degreeSubjects = new List<Subject>();
        }


        public void AddSubject(Subject s)
        {

            this.degreeSubjects.Add(s);
        }

        public bool isSubjectExists(string code)
        {
            foreach (var s in degreeSubjects)
            {
                if (s.code == code)
                {
                    return true;
                }
            }
            return false;
        }

        public int CalculateCreditHours()
        {
            int hours = 0;
            foreach (var s in degreeSubjects)
            {
                hours += s.creditHours;
            }
            return hours;
        }
    }
}
