using System;

namespace Polymorphism
{
    public class Calculator
    {
        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public virtual double Multiply(double number1, double number2)
        {
            Console.WriteLine("Calculator Multiply called.");
            return number1 * number2;
        }
    }
}