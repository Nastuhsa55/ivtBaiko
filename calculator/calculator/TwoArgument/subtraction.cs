namespace calculator
{
    /// <summary>
    /// Creating a class that computes subtraction
    /// </summary>
    public class Subtraction : ICalculator 
    {
        public double Calculate (double first, double second)
        {
            return first - second;
        }
    }
}
