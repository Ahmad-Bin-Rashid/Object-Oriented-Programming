using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.BL
{
    internal class Like
    {
        private string Name;
        public Like() { }
        public Like(string name)
        {
            this.Name = name;
        }

        public void GiveLike(string name)
        {
            this.Name = name;
        }

        public string GetLikeName()
        {
            return this.Name;
        }
    }
}
