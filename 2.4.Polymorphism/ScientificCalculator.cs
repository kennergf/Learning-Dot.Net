using System;

namespace Polymorphism
{
    public class ScientificCalculator : Calculator
    {
        public double Power(double number, double power)
        {
            double result = number;
            while (power != 1)
            {
                result = Multiply(result, number);
                power--;
            }
            return result;
        }

        public override double Multiply(double number1, double number2)
        {
            Console.WriteLine("ScientificCalculator Multiply called.");
            return number2 * number1;
        }
    }
}