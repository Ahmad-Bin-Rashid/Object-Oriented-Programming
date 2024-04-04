using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendLibrary.BL
{
    public class Subject
    {
        public int Code;
        public string Title;
        public int CreditHours;
        public int Fee;
        
        public Subject() { }
        public Subject(string title, int credithours, int fee)
        {
            this.Title = title;
            this.CreditHours = credithours;
            this.Fee = fee;
        }
    }
}
