using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaizanTask
{
    internal class Putabaaz
    {
        public Putabaaz()
        {
        }

        public Putabaaz(string pName, int pAge, char pGender)
        {
            name = pName;
            age = pAge;
            gender = pGender;
            id++;
        }
        public Putabaaz(string pName, int pAge, char pGender, int pID)
        {
            id = pID;
            name = pName;
            age = pAge;
            gender = pGender;
            id++;
        }
        public string name;
        public int age;
        public char gender;
        public int id;
    }
}
