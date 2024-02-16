using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1
{
    internal class Student
    {
        public Student(string name, float matric, float fsc, float ecat)
        {
            sname = name;
            matricMarks = matric;
            fscMarks = fsc;
            ecatMarks = ecat;
        }
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;
    }
}
