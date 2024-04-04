using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SigninSignupApp
{
    internal class UserDL
    {
        private static List<User> userList = new List<User>();
        /*private static List<User> userList = new List<User>();

        public static List<User> GetUserList()
        {
            return userList;
        }

        public static void AddUser(User user)
        {
            if (user != null)
            {
                userList.Add(user);
            }
        }

        public static void RemoveUser(User user)
        {
            userList.Remove(user);
        }

        public static bool IsValidUser(string userName)
        {
            foreach (var user in userList)
            {
                if (user.GetUserName() == userName)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckUser(string userName, string password)
        {
            foreach (var user in userList)
            {
                if (user.GetUserName() == userName && user.GetPassword() == password)
                {
                    return true;
                }
            }
            return false;
        }

        public static string CheckRole(string userName)
        {
            string role = null;
            foreach (var user in userList)
            {
                if (user.GetUserName() == userName)
                {
                    role = user.GetRole();
                }

            }
            return role;
        }

        public static User GetUser(string userName)
        {
            foreach (var user in userList)
            {
                if (user.GetUserName() == userName)
                {
                    return user;
                }
            }
            return null;
        }*/


        
        
        
        
        private static string constr = "Data Source=AHMAD-HP;Initial Catalog=SignInApp;Integrated Security=True;";
        
        public static bool AddUser(User u)
        {
            if (u != null)
            {
                userList.Add(u);

                SqlConnection conn = new SqlConnection(constr);
                string query = "insert into User (Name, UserName, Password, Role, Email, Number, CNIC) values (@name, @username, @password, @role, @email, @number, @cnic)";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@name", u.GetName());
                cmd.Parameters.AddWithValue("@username", u.GetUserName());
                cmd.Parameters.AddWithValue("@password", u.GetPassword());
                cmd.Parameters.AddWithValue("@role", u.GetRole());
                cmd.Parameters.AddWithValue("@email", u.GetEmail());
                cmd.Parameters.AddWithValue("@number", u.GetNumber());
                cmd.Parameters.AddWithValue("@cnic", u.GetCNIC());
                int a = cmd.ExecuteNonQuery();
                conn.Close();
                if (a > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }


        public static bool IsValidUser(string userName)
        {
            /*foreach (var user in userList)
            {
                if (user.GetUserName() == userName)
                {
                    return false;
                }
            }
            return true;*/
            
            SqlConnection conn = new SqlConnection(constr);
            string query = $"select * from User where UserName = '{userName}';";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                conn.Close();
                return false;
            }
            else
            {
                conn.Close();
                return true;
            }

        }


        public static bool CheckUser(string userName, string password)
        {
            /*foreach (var user in userList)
            {
                if (user.GetUserName() == userName && user.GetPassword() == password)
                {
                    return true;
                }
            }
            return false;*/

            SqlConnection conn = new SqlConnection(constr);
            string query = $"select * from User where UserName = '{userName}' and Password = '{password}';";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }


    }
}
