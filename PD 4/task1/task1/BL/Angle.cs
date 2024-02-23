using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.BL
{
    internal class Angle
    {
        public Angle(int degrees, float minutes, char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.direction = direction;
        }

        public int degrees;
        public float minutes;
        public char direction;

        public void ChangeAngle (int degrees, float minutes, char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.direction = direction;
        }

        public string DisplayAngle()
        {
            return $"{degrees}\u00b0{minutes}\' {direction}";
        }
    }
}
