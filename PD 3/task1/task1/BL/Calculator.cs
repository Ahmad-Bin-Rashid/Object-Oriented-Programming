using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
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
    }

}
