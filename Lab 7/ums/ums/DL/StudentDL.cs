using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ums
{
    internal class StudentDL
    {
        public static bool AddStudent(Student s, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = $"insert into Student (Name, Age, Fsc_Marks, Ecat_Marks) values ('{s.GetName()}', '{s.GetAge()}', '{s.GetFscMarks()}', '{s.GetEcatMarks()}')";

            SqlCommand command = new SqlCommand(query, connection);
            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            if (affectedRows > 0)
            {
                return true;
            }
            else { return false; }
        }
}
