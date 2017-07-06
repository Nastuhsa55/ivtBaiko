namespace calculator
{
    /// <summary>
    /// Creating a class that computes addition
    /// </summary>
    public class Addition : ICalculator 
    {
        public double Calculate (double first,double second) 
        {
            return first + second;
        }
    }
}
