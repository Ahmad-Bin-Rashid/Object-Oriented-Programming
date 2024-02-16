using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Player
    {
        public Player(char displayChar, int x, int y) 
        {
            this.displayChar = displayChar;
            this.x = x;
            this.y = y;
            score = 90;
        }

        public char displayChar;
        public int x, y, score;

        public void MoveLeft()
        {
            x--;
        }
        public void MoveRight()
        {
            x++;
        }
        public void MoveUp()
        {
            y--;
        }
        public void MoveDown()
        {
            y++;
        }

        public void ScoreIncrement()
        {
            score += 10;
        }

    }
}
