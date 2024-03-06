using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ums
{
    internal class Subject
    {
        private string code;
        private string type;
        private int creditHours;
        private double fees;

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
