using System;

namespace ControlStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            var input = Console.ReadLine();
            double number;
            var isNumber = double.TryParse(input, out number);

            if (isNumber)
            {
                Console.WriteLine($"You entered the number {number}");
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You entered the expected number 1");
                        // Stop the execution of switch, because we find the value
                        break;
                    case 2:
                        Console.WriteLine("You entered the expected number 2");
                        break;
                    default:
                        Console.WriteLine("You entered one unexpected number");
                        break;
                }
            }
            else
            {
                Console.WriteLine("The value entered is not a number!!");
            }

            Console.ReadKey();
        }
    }
}
