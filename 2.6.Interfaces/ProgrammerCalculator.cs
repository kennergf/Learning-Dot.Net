namespace Interfaces
{
    public class ProgrammerCalculator : ICalculator
    {
        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public double Multiply(double number1, double number2)
        {
            throw new System.NotImplementedException();
        }
    }
}