using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // the symbol [] create an array of the type that precedes the symbol
            int[] numbers = { 1, 3, 5 };
            // To access the value we use index, and the first index is 0
            int firstNumber = numbers[0];
            Console.WriteLine("First number: " + firstNumber);
            // Print all the elements
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            // Matrix
            string[,] matrix = new string[2, 3] { { "az", "sx", "dc" }, { "qa", "ws", "ed" } };
            // Print the matrix
            Console.Write(matrix[0, 0] + " ");
            Console.Write(matrix[0, 1] + " ");
            Console.Write(matrix[0, 2] + " ");
            // New line to be organized
            Console.WriteLine();
            Console.Write(matrix[1, 0] + " ");
            Console.Write(matrix[1, 1] + " ");
            Console.Write(matrix[1, 2] + " ");
            Console.WriteLine();

            // List
            List<int> listInteger = new List<int>();
            listInteger.Add(10);
            listInteger.Add(20);
            listInteger.Add(30);
            listInteger.Add(40);
            listInteger.Add(50);
            
            listInteger.ForEach(number => Console.WriteLine(number));

            Console.ReadKey();
        }
    }
}
