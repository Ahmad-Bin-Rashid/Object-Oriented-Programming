using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ums
{
    internal class DegreeProgram
    {
        private string title;
        private string duration;
        private int seats;

        private List<Subject> degreeSubjects = new List<Subject>();

        public DegreeProgram(string title, string duration, int seats, List<Subject> subjects)
        {
            this.title = title;
            this.duration = duration;
            this.seats = seats;
            this.degreeSubjects = subjects;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public string GetDuration()
        {
            return this.duration;
        }

        public int GetSeats()
        {
            return this.seats;
        }

        public void AddSubject(Subject s)
        {

            this.degreeSubjects.Add(s);
        }

        public bool isSubjectExists(string code)
        {
            foreach (var s in degreeSubjects)
            {
                if (s.GetCode() == code)
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
                hours += s.GetCreditHour();
            }
            return hours;
        }
    }
}
