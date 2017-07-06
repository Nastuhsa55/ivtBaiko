namespace calculator
{
    /// <summary>
    /// Creating a class that computes multiplication
    /// </summary>
    public class Multiplication: ICalculator 
    {
        public double Calculate (double first, double second)
        {
            return first * second;
        }
    }
}
