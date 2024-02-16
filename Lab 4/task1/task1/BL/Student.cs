using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Student
    {
        public Student(string sname, int rolln, int matric, int fsc, int ecat, string town, bool hostelite)
        {
            name = sname;
            rollno = rolln;
            matricMarks = matric;
            fscMarks = fsc;
            ecatMarks = ecat;
            homeTown = town;
            isHostelite = hostelite;
        }
        public string name;
        public int rollno;
        public int matricMarks; 
        public int fscMarks;
        public int ecatMarks;
        public string homeTown;
        public bool isHostelite;
        public bool isTakingScholarship;

        public double CalculateMerit()
        {
            double merit;
            merit = (matricMarks/1100 * 20) + (fscMarks/1100 * 40) + (ecatMarks/400 * 40);
            return merit;
        }
        public bool isEligibleforScholarship()
        {
            double merit = CalculateMerit();
            if (merit > 80.0 && isHostelite)
            {
                isTakingScholarship = true;
                return true;
            }
            else
            {
                isTakingScholarship = false;
                return false;
            }
        }

    }
}
