using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICoreBL.Generic;
using System.Data.SqlClient;

namespace ICoreBL.DL
{
    public class MuserDBStore: IMUserStore
    {
        public string connectionString = "";
        public MuserDBStore(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public MUser SignIn(MUser user)
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
        private bool validateUser(MUser user, string connectionString)
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
        public void SignUp(MUser user)
        {
            if (!validateUser(user, connectionString))
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = String.Format("insert into MUser (userName, userPassword, userRole) VALUES('{0}', '{1}', '{2}')", user.getUserName(), user.getUserPassword(), user.getUserRole());
                SqlCommand command = new SqlCommand(query, connection);
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

            }

        }

        public List<MUser> getAllUsers()
        {
            List<MUser> usersList = new List<MUser>();
            SqlConnection connection = new SqlConnection(connectionString);
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
