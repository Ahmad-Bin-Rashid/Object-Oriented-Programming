using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.BL;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ship> ships = new List<Ship>();

            while (true)
            {
                string option = Menu();
                switch (option)
                {
                    case "1":
                        ships.Add(AddShip());
                        break;

                    case "2":
                        ViewPosition(ships);
                        Console.ReadKey();
                        break;

                    case "3":
                        ViewSerialNo(ships);
                        Console.ReadKey();
                        break;

                    case "4":
                        ChangePosition(ships);
                        Console.ReadKey();
                        break;

                    case "5":
                        return;
                }
            }
        }

        static string Menu()
        {
            string option;
            Console.WriteLine("Choose from Following: ");
            Console.WriteLine("1.Add Ship");
            Console.WriteLine("2.View Ship Position");
            Console.WriteLine("3.View Ship Serial Number");
            Console.WriteLine("4.Change Ship Position");
            Console.WriteLine("5.Exit");
            Console.Write("Your Option: ");
            option = Console.ReadLine();

            return option;   
        }

        static Ship AddShip()
        {
            Console.Write("Enter Ship Number:");
            string srNo = Console.ReadLine();
            Console.WriteLine("Enter Ship Latitude:");
            Console.Write("Enter Latitude’s Degree:");
            int latDegree = int.Parse(Console.ReadLine());
            Console.Write("Enter Latitude’s Minute:");
            float latMinute = float.Parse(Console.ReadLine());
            Console.Write("Enter Latitude’s Direction:");
            char latDirection = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ship Longitude:");
            Console.Write("Enter Longitude’s Degree:");
            int longDegree = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude’s Minute:");
            float longMinute = float.Parse(Console.ReadLine());
            Console.Write("Enter Longitude’s Direction:");
            char longDirection = char.Parse(Console.ReadLine());

            Ship s = new Ship(srNo, latDegree, latMinute, latDirection, longDegree, longMinute, longDirection);
            return s;
        }

        static void ViewPosition(List<Ship> ships)
        {
            Console.Write("Enter Ship Serial Number to find its position:");
            string srNo = Console.ReadLine();
            foreach (var ship in ships)
            {
                if (srNo == ship.srNo)
                {
                    Console.WriteLine($"Ship is at {ship.DisplayLatitude()} and {ship.DisplayLongitude()}.");
                }
            }
        }
        static void ViewSerialNo(List<Ship> ships)
        {
            Console.WriteLine("Enter Ship Latitude:");
            Console.Write("Enter Latitude’s Degree:");
            int latDegree = int.Parse(Console.ReadLine());
            Console.Write("Enter Latitude’s Minute:");
            int latMinute = int.Parse(Console.ReadLine());
            Console.Write("Enter Latitude’s Direction:");
            char latDirection = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ship Longitude:");
            Console.Write("Enter Longitude’s Degree:");
            int longDegree = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude’s Minute:");
            int longMinute = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude’s Direction:");
            char longDirection = char.Parse(Console.ReadLine());
            foreach (var ship in ships)
            {
                if (latDegree == ship.latitude.degrees && latMinute == ship.latitude.minutes && latDirection == ship.latitude.direction && longDegree == ship.longitude.degrees && longMinute == ship.longitude.minutes && longDirection == ship.longitude.direction)
                {
                    Console.WriteLine($"Ship’s serial number is{ship.DisplaySrNo()}.");
                }
            }
        }
        
        static void ChangePosition(List<Ship> ships)
        {
            Console.Write("Enter Ship’s serial number whose position you want to change: ");
            string srNo = Console.ReadLine();

            foreach (var ship in ships)
            {
                if (srNo == ship.srNo)
                {
                    Console.Write("Enter Latitude’s Degree:");
                    int latDegree = int.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude’s Minute:");
                    int latMinute = int.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude’s Direction:");
                    char latDirection = char.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Ship Longitude:");
                    Console.Write("Enter Longitude’s Degree:");
                    int longDegree = int.Parse(Console.ReadLine());
                    Console.Write("Enter Longitude’s Minute:");
                    int longMinute = int.Parse(Console.ReadLine());
                    Console.Write("Enter Longitude’s Direction:");
                    char longDirection = char.Parse(Console.ReadLine());

                    ship.latitude.ChangeAngle(latDegree, latMinute, latDirection);
                    ship.longitude.ChangeAngle(longDegree, longMinute, longDirection);
                }
            }
            

        }

    }
}
