using System;

namespace Interfaces
{
    public class ScientificCalculator : ICalculator
    {
        public double Add(double number1, double number2)
        {
            return number2 + number1;
        }

        public double Multiply(double number1, double number2)
        {
            throw new NotImplementedException();
        }
    }
}