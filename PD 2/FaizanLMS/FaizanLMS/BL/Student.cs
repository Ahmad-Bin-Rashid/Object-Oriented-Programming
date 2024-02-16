using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaizanLMS.BL
{
    internal class Student
    {
        public Student(string name, string username, string password, string rollno)
        {
            this.name = name;
            this.username = username;
            this.password = password;
            this.rollno = rollno;
        }
        public string name;
        public string rollno;
        public string username;
        public string password;
        public List<Course> courses = new List<Course>();

        public void enroll(Course c)
        {
            courses.Add(c);
        }
    }
}
