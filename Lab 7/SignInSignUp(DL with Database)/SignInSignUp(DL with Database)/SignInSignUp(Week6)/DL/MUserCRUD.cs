using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace SignInSignUp_Week6_
{
    class MUserCRUD
    {

        public static MUser SignIn(MUser user, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string searchQuery = String.Format("Select * from MUser where userName = '{0}' and userPassword = '{1}'", user.getUserName(), user.getUserPassword());
            SqlCommand command = new SqlCommand(searchQuery, connection);
            SqlDataReader data = command.ExecuteReader();
            if (data.Read())
            {
                
                MUser storedUser = new MUser(data.GetString(1), data.GetString(2), data.GetString(3));
                connection.Close();
                return storedUser;
            }
            connection.Close();
            return null;
        }

       

        private static bool validateUser(MUser user, string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string searchQuery = String.Format("Select * from MUser where userName = '{0}'", user.getUserName());
            SqlCommand command = new SqlCommand(searchQuery, connection);
            SqlDataReader data = command.ExecuteReader();
            bool check = data.Read();
            connection.Close();
            return check;
        }
        public static bool storeUserIntoDb(MUser user, string connectionString)
        {
            if (!validateUser(user, connectionString))
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = String.Format("insert into MUser (userName, userPassword, userRole) VALUES('{0}', '{1}', '{2}')", user.getUserName(), user.getUserPassword(), user.getUserRole());
                SqlCommand command = new SqlCommand(query, connection);
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            return false;

        }

        public static List<MUser> getAllUsers(string dbConnectionString)
        {
            List<MUser> usersList = new List<MUser>();
            SqlConnection connection = new SqlConnection(dbConnectionString);
            connection.Open();
            string query = "SELECT * FROM MUser";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                MUser user = new MUser(reader.GetString(1), reader.GetString(2), reader.GetString(3));
                usersList.Add(user);
            }
            connection.Close();
            return usersList;
        }

    }
}
