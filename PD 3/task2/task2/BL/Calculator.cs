using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Calculator
    {
        public double number1;
        public double number2;

        public Calculator()
        {
            number1 = 10;
            number2 = 10;
        }

        public Calculator(double num1, double num2)
        {
            number1 = num1;
            number2 = num2;
        }

        public double Add()
        {
            return number1 + number2;
        }

        public double Subtract()
        {
            return number1 - number2;
        }

        public double Multiply()
        {
            return number1 * number2;
        }

        public double Divide()
        {
            if (number2 != 0)
            {
                return number1 / number2;
            }
            else
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return double.NaN;
            }
        }

        public double Modulo()
        {
            if (number2 != 0)
            {
                return number1 % number2;
            }
            else
            {
                Console.WriteLine("Error: Cannot calculate modulo with divisor being zero.");
                return double.NaN;
            }
        }

        public double Sqrt(double num)
        {
            return Math.Sqrt(num);
        }

        public double Exp(double exponent)
        {
            return Math.Exp(exponent);
        }

        public double Log(double num)
        {
            return Math.Log(num);
        }

        public double Sin(double angle)
        {
            return Math.Sin(Math.PI * angle / 180.0);
        }

        public double Cos(double angle)
        {
            return Math.Cos(Math.PI * angle / 180.0);
        }

        public double Tan(double angle)
        {
            return Math.Tan(Math.PI * angle / 180.0);
        }
    }

}
