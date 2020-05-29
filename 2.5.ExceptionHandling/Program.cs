using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = null;

            try
            {
                Console.WriteLine("Execute addition");
                calc.Add(5, 6);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("From ArgumentNullException: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("From ArgumentException: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("From Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally always execute!");
            }
        }
    }
}
