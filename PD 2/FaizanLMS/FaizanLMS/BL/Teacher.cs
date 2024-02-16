using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaizanLMS.BL
{
    internal class Teacher
    {
        public Teacher(string name, string username, string password) 
        {
            this.name = name;
            this.username = username;
            this.password = password;
        }
        public string name;
        public string username;
        public string password;

    }
}
