using System;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lifecicle
            var calc1 = new ScientificCalculator();
            Console.WriteLine();
            var calc2 = new ScientificCalculator(0, "x")
            {
                EndAngle = 360
            };

            // Disposable
            ScientificCalculator calc3 = null;
            try
            {
                calc3 = new ScientificCalculator();
            }
            finally
            {
                if (calc3 != null)
                    calc3.Dispose();
            }

            // Dispose after execute instructions
            using(var calc4 = new ScientificCalculator())
            {
                // Execute calculation here
            }
            Console.ReadKey();
        }
    }
}
