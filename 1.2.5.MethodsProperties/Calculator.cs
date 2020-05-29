using System;

namespace MethodsProperties
{
    class Calculator
    {
        private double[] numbers = new double[2];
        private double result;

        public double First
        {
            get { return numbers[0]; }
        }

        public double Second
        {
            get { return numbers[2]; }
        }

        public double Result
        {
            get { return result; }
            set { result = value; }
        }

        public void GetNumber(string whichNumber)
        {
            Console.Write($"{whichNumber} Number: ");
            string numberInput = Console.ReadLine();
            double number;
            if (!double.TryParse(numberInput, out number))
            {
                throw new FormatException();
            }

            if (whichNumber == "First")
            {
                numbers[0] = number;
            }
            else if (whichNumber == "Second")
            {
                numbers[1] = number;
            }
            else
            {
                // Throw an exception because the argument is not valid
                throw new ArgumentException();
            }
        }

        public void AddNumbers()
        {
            Result = numbers[0] + numbers[1];
        }

        public void PrintResult()
        {
            Console.WriteLine($"Your result is {Result}");
        }
    }
}