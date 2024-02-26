using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_app
{
    internal class Customer
    {
        public Customer(int id, string fullName, string userName, string password, string email, double phoneNo)
        {
            this.id = id + 1;
            this.user.fullName = fullName;
            this.user.userName = userName;
            this.user.email = email;
            this.user.phoneNo = phoneNo;
            this.user.password = "123456";
        }

        public int id;
        public Person user;
    }
}
