using System;

namespace Inheritance
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
    }
}