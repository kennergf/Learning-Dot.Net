using System;

namespace LoopingStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix = new string[2, 3] { { "az", "sx", "dc" }, { "qa", "ws", "ed" } };
            Console.WriteLine($"The Rank of the matrix is {matrix.Rank}");
            Console.WriteLine($"The Length of the matrix is {matrix.Length}");
            Console.WriteLine();
            Console.WriteLine("Print Matrix");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Print Array");
            // Array
            int[] numbers = { 1, 3, 5 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            Console.WriteLine("Print with While");
            double[] temperatures = { 72.3, 73.8, 75.1, 74.9 };
            int interactor = 0;
            while (interactor < temperatures.Length)
            {
                Console.WriteLine(temperatures[interactor]);
                interactor++;
            }

            Console.WriteLine();
            Console.WriteLine("Print with Do-While");
            interactor = 0;
            do
            {
                Console.WriteLine(temperatures[interactor]);
                interactor++;
            }
            while (interactor < temperatures.Length);

            Console.ReadKey();
        }
    }
}
