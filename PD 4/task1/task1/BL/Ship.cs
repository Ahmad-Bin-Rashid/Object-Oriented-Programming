using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.BL
{
    internal class Ship
    {
        public Ship(string srNo, int latDegree, float latMinute, char latDirection, int longDegree, float longMinute, char longDirection) 
        {
            this.srNo = srNo;

            latitude = new Angle(latDegree, latMinute, latDirection);
            //latitude.degrees = latDegree;
            //latitude.minutes = latMinute;
            //latitude.direction = latDirection;

            longitude = new Angle(longDegree, longMinute, longDirection);
            //longitude.degrees = longDegree;
            //longitude.minutes = longMinute;
            //longitude.direction = longDirection;
        }

        public string srNo;
        public Angle latitude;
        public Angle longitude;

        public string DisplaySrNo()
        {
            return srNo;
        }

        public string DisplayLatitude()
        {
            return latitude.DisplayAngle();
        }

        public string DisplayLongitude() 
        {
            return longitude.DisplayAngle();
        }
    }
}
