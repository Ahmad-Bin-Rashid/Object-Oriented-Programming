using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class StudentDL
    {

        private static List<Student> studentList = new List<Student>();;

        public static void AddStudent(Student s)
        {
            studentList.Add(s);
        }

        public static List<Student> GetStudentList()
        {
            return studentList;
        }

    }
}
}
