using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Student
    {
        public Student(string name, int age, double fscMarks, double ecatMarks) 
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;

        }

        public string name;
        public int age;
        public double fscMarks;
        public double ecatMarks;
        public double Merit;

        public List<DegreeProgram> prefrences;
        public DegreeProgram degree;
        public List<Subject> registeredSubjects;


        public void SelectPreferences(DegreeProgram dp)
        {
            this.prefrences.Add(dp);
        }

        public void RegisterSubject(Subject s)
        {
            this.registeredSubjects.Add(s);
        }

    }
}
