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
            Calculator calculator = null;
            while (true)
            {
                Console.Clear();
                int choice = ShowMenu();

                switch (choice)
                {
                    case 1:
                        calculator = CreateObject();
                        break;

                    case 2:
                        ChangeValues(calculator);
                        break;

                    case 3:
                        if (calculator != null)
                        {
                            DisplayResult("Addition", calculator.Add());
                        }
                        else
                        {
                            ErrorMessage();
                        }
                        break;

                    case 4:
                        if (calculator != null)
                        {

                            DisplayResult("Subtraction", calculator.Subtract());
                        }
                        else
                        {
                            ErrorMessage();
                        }
                        break;

                    case 5:
                        if (calculator != null)
                        {
                            DisplayResult("Multiplication", calculator.Multiply());
                        }
                        else
                        {
                            ErrorMessage();
                        }
                        break;

                    case 6:
                        if (calculator != null)
                        {
                            DisplayResult("Division", calculator.Divide());
                        }
                        else
                        {
                            ErrorMessage();
                        }
                        break;

                    case 7:
                        if (calculator != null)
                        {
                            DisplayResult("Modulo", calculator.Modulo());
                        }
                        else
                        {
                            ErrorMessage();
                        }
                        break;


                    case 8:
                        if (calculator != null)
                        {
                            DisplayResult("Square Root", calculator.Sqrt(calculator.number1));
                        }
                        else
                        {
                            ErrorMessage();
                        }
                        break;

                    case 9:
                        if (calculator != null)
                        {
                            Console.Write("Enter exponent for exponential function: ");
                            double exponent = double.Parse(Console.ReadLine());
                            DisplayResult("Exponential Function", calculator.Exp(exponent));
                        }
                        else
                        {
                            ErrorMessage();
                        }
                        break;

                    case 10:
                        if (calculator != null)
                        {
                            Console.Write("Enter a number for natural logarithm: ");
                            double logNum = double.Parse(Console.ReadLine());
                            DisplayResult("Logarithm", calculator.Log(logNum));
                        }
                        else
                        {
                            ErrorMessage();
                        }
                        break;

                    case 11:
                        if (calculator != null)
                        {
                            Console.Write("Enter angle in degrees for sine function: ");
                            double angleSin = double.Parse(Console.ReadLine());
                            DisplayResult("Sine", calculator.Sin(angleSin));
                        }
                        else
                        {
                            ErrorMessage();
                        }
                        break;

                    case 12:
                        if (calculator != null)
                        {
                            Console.Write("Enter angle in degrees for cosine function: ");
                            double angleCos = double.Parse(Console.ReadLine());
                            DisplayResult("Cosine", calculator.Cos(angleCos));
                        }
                        else
                        {
                            ErrorMessage();
                        }
                        break;

                    case 13:
                        if (calculator != null)
                        {
                            Console.Write("Enter angle in degrees for tangent function: ");
                            double angleTan = double.Parse(Console.ReadLine());
                            DisplayResult("Tangent", calculator.Tan(angleTan));
                        }
                        else
                        {
                            ErrorMessage();
                        }
                        break;

                    case 14:
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 8.");
                        break;
                }
                Console.ReadKey();
                Console.WriteLine();
            }
        }

        static int ShowMenu()
        {
            Console.WriteLine("Select from Following:");
            Console.WriteLine("1. Create a Single Object of Calculator");
            Console.WriteLine("2. Change Values of Attributes");
            Console.WriteLine("3. Add");
            Console.WriteLine("4. Subtract");
            Console.WriteLine("5. Multiply");
            Console.WriteLine("6. Divide");
            Console.WriteLine("7. Modulo");
            Console.WriteLine("8. Square Root");
            Console.WriteLine("9. Exponential Function");
            Console.WriteLine("10. Logarithm");
            Console.WriteLine("11. Sine");
            Console.WriteLine("12. Cosine");
            Console.WriteLine("13. Tangent");
            Console.WriteLine("14. Exit");
            Console.Write("Enter your choice (1-12): ");

            return int.Parse(Console.ReadLine());
        }

        static Calculator CreateObject()
        {
            Console.Write("Enter value for number1: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter value for number2: ");
            double num2 = double.Parse(Console.ReadLine());
            Calculator calculator = new Calculator(num1, num2);
            return calculator;
        }

        static void ChangeValues(Calculator calculator)
        {
            if (calculator != null)
            {
                Console.Write("Enter new value for number1: ");
                calculator.number1 = double.Parse(Console.ReadLine());
                Console.Write("Enter new value for number2: ");
                calculator.number2 = double.Parse(Console.ReadLine());
            }
            else
            {
                ErrorMessage();
            }
        }

        static void DisplayResult(string operationName, double value)
        {
            Console.WriteLine($"Result of {operationName}: {value}");
        }

        static void ErrorMessage()
        {
            Console.WriteLine("Error: Calculator object not created yet. Create an object first.");
        }
    }
}

