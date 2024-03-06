using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Subject
    {
        public string code;
        public string type;
        public int creditHours;
        public double fees;

        public Subject(string code, string type, int creditHours, double fees) 
        {
            this.code = code;
            this.type = type;
            this.creditHours = creditHours;
            this.fees = fees;
        }

        public string GetCode()
        {
            return code;
        }

        public string GetType()
        {
            return type;
        }

        public int GetCreditHour()
        {
            return creditHours;
        }

        public double GetFees()
        {
            return fees;
        }
    }
}
