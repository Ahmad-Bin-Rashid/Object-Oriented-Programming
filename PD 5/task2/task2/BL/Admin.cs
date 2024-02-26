using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Admin
    {
        string Username;
        string Password;
        string Role;

        public Admin(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.Role = "admin";
        }

        public string GetUsername()
        {
            return this.Username;
        }
        public string GetPassword()
        {
            return this.Password;
        }
        public string GetRole()
        {
            return this.Role;
        }
    }
}
