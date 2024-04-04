using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigninSignupApp
{
    internal class User
    {
        private string Name;
        private string UserName;
        private string Password;
        private string Role;
        private string Email;
        private string Number;
        private string CNIC;

        public User(string name, string userName, string password, string role, string email, string number, string cnic)
        {
            this.Name = name;
            this.UserName = userName;
            this.Password = password;
            this.Role = role;
            this.Email = email;
            this.Number = number;
            this.CNIC = cnic;
        }


        public string GetName()
        {
            return this.Name;
        }
        public string GetUserName()
        {
            return this.UserName;
        }
        public string GetPassword()
        {
            return this.Password;
        }
        public string GetRole()
        {
            return this.Role;
        }
        public string GetEmail()
        {
            return this.Email;
        }
        public string GetNumber()
        {
            return this.Number;
        }
        public string GetCNIC()
        {
            return this.CNIC;
        }


        public void ChangeName(string name)
        {
            this.Name = name;
        }
        public void ChangeUserName(string username)
        {
            this.UserName = username;
        }
        public void ChangePassword(string password)
        {
            this.Password = password;
        }
        public void ChangeEmail(string email)
        {
            this.Email = email;
        }
        public void ChangeNumber(string number)
        {
            this.Number = number;
        }
        public void ChangeCNIC(string cnic)
        {
            this.CNIC = cnic;
        }
    }
}
