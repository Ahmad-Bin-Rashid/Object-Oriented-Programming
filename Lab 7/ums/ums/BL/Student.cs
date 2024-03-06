using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ums
{
    internal class Student
    {
        private string name;
        private int age;
        private float fscMarks;
        private float ecatMarks;
        private float merit;

        private List<DegreeProgram> preferences;
        private DegreeProgram enrolledDegree;
        private List<Subject> registeredSubjects;

        public Student(string name, int age, float fscMarks, float ecatMarks)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;

        }

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public float GetFscMarks()
        {
            return fscMarks;
        }

        public float GetEcatMarks()
        {
            return ecatMarks;
        }

        public float GetMerit()
        {
            return merit;
        }

        public DegreeProgram GetEnrolledDegree()
        {
            return enrolledDegree;
        }

        public List<DegreeProgram> GetPreferences()
        {
            return preferences;
        }

        public List<Subject> GetRegisteredSubjects()
        {
            return registeredSubjects;
        }

        public void SetEnrolledDegree(DegreeProgram dp)
        {
            this.enrolledDegree = dp;
        }

        public void AddPreferences(DegreeProgram dp)
        {
            this.preferences.Add(dp);
        }

        public void AddRegisteredSubject(Subject s)
        {
            this.registeredSubjects.Add(s);
        }
    }
}
