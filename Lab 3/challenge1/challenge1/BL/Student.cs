using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1
{
    internal class Student
    {
        public string name;
        public double matricMarks;
        public double fscMarks;
        public double ecatMarks;
        public double aggregate;

        public Student(string Name, double matric, double fsc, double ecat)
        {
            name = Name;
            matricMarks = matric;
            fscMarks = fsc;
            ecatMarks = ecat;
        }

        public void CalculateAggregate()
        {
            aggregate = ((matricMarks / 1100) * 17)+ ((fscMarks / 1100) * 50) + ((ecatMarks / 400) * 33);
        }

        
    }
}
