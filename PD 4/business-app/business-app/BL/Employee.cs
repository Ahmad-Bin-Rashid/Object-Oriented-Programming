using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_app
{
    internal class Employee
    {
        public Employee(int id, string fullName, string userName, string email, double phoneNo, double CNIC)
        {
            this.id = id + 1;
            this.user.fullName = fullName;
            this.user.userName = userName;
            this.user.email = email;
            this.user.phoneNo = phoneNo;
            this.user.CNIC = CNIC;
            this.user.password = "123456";
        }

        public int id;
        public Person user;
        public const string code = "employ123";
    }
}
