using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Enemy
    {
        static Random rand = new Random();

        public Enemy(char displayChar, int x, int y)
        {
            this.displayChar = displayChar;
            this.x = x;
            this.y = y;
        }

        public char displayChar;
        public int x, y;


        public void SetPosition()
        {
            x = rand.Next(5, 55);
            y = rand.Next(2, 18);
        }


    }

}
