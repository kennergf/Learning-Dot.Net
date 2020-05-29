﻿using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator sciCalc = new ScientificCalculator();
            double sciCalcResult = sciCalc.Add(2, 5);
            Console.WriteLine($"Scientific Calculator 2 + 5: {sciCalcResult}");
            ICalculator prgCalc = new ProgrammerCalculator();
            double prgCalcResult = prgCalc.Add(5, 10);
            Console.WriteLine($"Programmer Calculator 5 + 10: {prgCalcResult}");
            Console.ReadKey();
        }
    }
}
