using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ums
{
    internal class DegreeProgramDL
    {
        private static List<DegreeProgram> degreePrograms = new List<DegreeProgram>();

        public static void AddDegreeProgram(DegreeProgram degreeProgram)
        {
            degreePrograms.Add(degreeProgram);
        }

        public static List<DegreeProgram> GetDegreePrograms()
        {
            return degreePrograms;
        }

        public static DegreeProgram CheckDegree(string title)
        {
            foreach (var dp in degreePrograms)
            {
                if (title == dp.GetTitle())
                {
                    return dp;
                }
            }
            return null;
        }
    }
}
