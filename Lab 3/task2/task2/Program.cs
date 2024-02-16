using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first NUmber: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second NUmber: ");
            double num2 = double.Parse(Console.ReadLine());

            Calculator calculator = new Calculator(num1, num2);

            Console.WriteLine($"Sum of Numbers: {calculator.Add()}");
            Console.WriteLine($"Difference of Numbers: {calculator.Subtract()}");
            Console.WriteLine($"Product of Numbers: {calculator.Multiply()}");
            Console.WriteLine($"Division of Numbers: {calculator.Divide()}");
            Console.ReadKey();

        }
    }
}
