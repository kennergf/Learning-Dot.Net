using System;

namespace Polymorphism
{
    public class ProgrammerCalculator : Calculator
    {
        public int Or(int number1, int number2)
        {
            return number1 | number2;
        }

        public override double Multiply(double number1, double number2)
        {
            Console.WriteLine("ProgrammerCalculator Multiply called.");
            return base.Add(number1, number2);
        }
    }
}