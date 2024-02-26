using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class StudentDL
    {

        public static List<Student> studentList;

        public static void AddStudent(Student s)
        {
            studentList.Add(s);
        }


    }
}
