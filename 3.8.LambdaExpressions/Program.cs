using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Action is a reusable delegate
            Action hello = () => Console.WriteLine("Hello!");
            // hello is a variable of Action delegate type, so you can call it just like a method.
            hello();

            // Call the method ValidateInput, and create the validator using lambda
            ValidateInput(word =>
            {
                int count = word.Length;
                return count > 3;
            });

            Console.ReadKey();
        }

        // Predicate is a generic delegate that receives one string as parameter
        public static void ValidateInput(Predicate<string> validator)
        {
            string input = "Hello";
            bool isValid = validator(input);
            Console.WriteLine($"Is valid: {isValid}");
        }
    }
}
