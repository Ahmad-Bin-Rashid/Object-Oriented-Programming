using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaizanTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            takeInput(list);
            printHighest(list);
        }

        static void takeInput(List<int> list)
        {
            Console.Write("You want to make the list of numbers: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.Write("Element "+ i + ": ");
                list.Add(int.Parse(Console.ReadLine()));
            }
        }

        static void printHighest(List<int> list)
        {
            int highestNum =  0;
            int highestCount = 0;
            int num;
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                num = list[i];
                for (int j = 0; j < list.Count; j++)
                {
                    if (num == list[j])
                    {
                        count++;
                    }
                }
                if (count > highestCount)
                {
                    highestNum = list[i];
                    highestCount = count;
                }
                count = 0;
            }

            Console.WriteLine("Number : " + highestNum + " has highest count of " + highestCount + ".");
            Console.ReadKey();
        }

    }
}
