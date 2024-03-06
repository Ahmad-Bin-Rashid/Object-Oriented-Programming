using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spacex
{
    internal class Ship
    {
        public string shipName;
        public string owner = "Chauhdry";
        public string driver;
        public string destination;
        List<Person> passengers = new List<Person>();
    }
}
