using System;

namespace MethodsProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Procedural
            Console.Write("First number: ");
            string firstNumberInput = Console.ReadLine();
            double firstNumber = double.Parse(firstNumberInput);

            Console.Write("Second number: ");
            string secondNumberInput = Console.ReadLine();
            double secondNumber = double.Parse(secondNumberInput);

            double result = firstNumber + secondNumber;

            Console.WriteLine($"Your result is {result}");

            // Modularized
            var calc = new Calculator();

            calc.GetNumber("First");
            calc.GetNumber("Second");
            calc.AddNumbers();

            calc.PrintResult();    

            Console.ReadKey();
        }
    }
}
