using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Subject
    {
        public Subject(string code, string type, int creditHours, double fees) 
        {
            this.code = code;
            this.subjectType = type;
            this.creditHours = creditHours;
            this.fees = fees;
        }
        public string code;
        public string subjectType;
        public int creditHours;
        public double fees;

    }
}
