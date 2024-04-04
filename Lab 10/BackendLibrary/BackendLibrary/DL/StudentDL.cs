using BackendLibrary.BL;
using BackendLibrary.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendLibrary.DL
{
    public class StudentDL
    {
        private static List<Student> students = new List<Student>();
        public static bool SaveStudent(Student student)
        {
            string connectiongString = Utility.GetConnectionString();
            SqlConnection connection  = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("Insert into Student(Roll,Name,Fsc,Matric,Ecat) Values({0}, '{1}', {2}, {3}, {4})", student.Roll, student.Name, student.FSc, student.Matric, student.Ecat);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            
            connection.Close();
            foreach(DegreeProgram degree in student.Prefrences)
            {
                SavePrefrence(degree, student.Roll);
            }

            foreach (Subject subject in student.RegisteredSubjects)
            {
                SaveRegisteredSubjects(subject, student.Roll);
            }

            if (rows > 0 )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool SavePrefrence(DegreeProgram degreeProgram, int roll) {

            string connectiongString = Utility.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("Insert into Preferences(DegreeTitle, Student) values('{0}', {1})", degreeProgram.Title, roll );
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0) { return true; }
            else return false;
          
        }

        public static bool SaveRegisteredSubjects(Subject subject, int roll)
        {

            string connectiongString = Utility.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();
            string query = string.Format("Insert into RegisteredSubject(SubjectCode, Student) values('{0}', {1})", subject.Code, roll);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            connection.Close();
            if (rows > 0) { return true; }
            else return false;

        }


        public static void FindStudentByRoll(string roll)
        {
            string connectiongString = Utility.GetConnectionString();
            SqlConnection connection = new SqlConnection( connectiongString);
            connection.Open();

            string query = string.Format("select * from Student where Roll = {0} ", roll);
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            Student student;
            if (reader.Read())
            {

                int dbroll = Convert.ToInt32(reader["Roll"]);
                string Name = Convert.ToString(reader["Name"]);
                float Fsc = Convert.ToSingle(reader["Fsc"]);
                float matric = Convert.ToSingle(reader["Matric"]);
                float Ecat = Convert.ToSingle(reader["Ecat"]);
                student  = new Student(dbroll, Name, Fsc, matric, Ecat);
                student.Prefrences =  LoadStudentAllPrefencesbyRoll(dbroll);
                student.RegisteredSubjects =  LoadStudentRegisteredSubjectbyRoll(dbroll);

            }

        }


        public static List<DegreeProgram> LoadStudentAllPrefencesbyRoll(int roll)
        {
            string connectiongString = Utility.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("select * from Preferences where Student = {0} ", roll);
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            List<DegreeProgram> list = new List<DegreeProgram>();
            while(reader.Read()) {

                string pref = Convert.ToString(reader["DegreeTitle"]);
                DegreeProgram degreeProgram = new DegreeProgram();
                degreeProgram.Title = pref;

                list.Add(degreeProgram);    
            
            }
            return list;
        }

        public static List<Subject> LoadStudentRegisteredSubjectbyRoll(int roll)
        {
            string connectiongString = Utility.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectiongString);
            connection.Open();

            string query = string.Format("select * from RegisteredSubject where Student = {0} ", roll);
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            List<Subject> list = new List<Subject>();
            while (reader.Read())
            {

                int registered = Convert.ToInt32(reader["SubjectCode"]);
                Subject subject = new Subject();
                subject.Code = registered;

                list.Add(subject);

            }
            return list;
        }


        public static List<Student> GetAllStudents()
        {

            return students;
        }

        public static DataTable GetGridViewData()
        {
            SqlConnection connection = new SqlConnection(Utility.GetConnectionString());
            connection.Open();
            string query = "select * from Student;";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            AddDataRows(dt, GetAllStudents());
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }

        private static DataTable AddDataRows(DataTable dt, List<Student> students)
        {
            foreach (var s in students)
            {
                dt.Rows.Add(s.Roll, s.Name, s.Matric, s.FSc, s.Ecat, s.DegreeProgram);

            }
            return dt;
        }

    }
}
