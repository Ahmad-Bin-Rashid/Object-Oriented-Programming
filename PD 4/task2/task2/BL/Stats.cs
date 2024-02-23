using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Stats
    {
        public string skillname;
        public double damage;
        public double penetration;
        public double heal;
        public double cost;
        public string description;
        public Stats(string skillname, double damage, double penetration, double heal, double cost, string description)
        {
            this.skillname = skillname;
            this.damage = damage;
            this.penetration = penetration;
            this.heal = heal;
            this.cost = cost;
            this.description = description;
        }
        public Stats()
        {
        }
    }
}
