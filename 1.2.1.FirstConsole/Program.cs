using System;

namespace FirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // 
            Console.WriteLine("Hello, What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}, How old are you? ", name);
            // We read a string, but convert it to integer
            var age = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0} years old, ", age);
            if (age < 20)
            {
                Console.WriteLine("Realy? You are soo young!");
            }
            else if(age >= 20 && age < 30)
            {
                Console.WriteLine("Very well, wellcome!");
            }
            else if(age >= 30 && age < 100)
            {
                Console.WriteLine("You look yonger!!");
            }
            else if( age >= 100)
            {
                Console.WriteLine("I can't believe!!!");
            }

            // Await the user press any key to close the application
            Console.ReadKey();
        }
    }
}
