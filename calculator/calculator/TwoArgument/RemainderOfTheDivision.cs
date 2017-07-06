namespace calculator
{
    /// <summary>
    /// Creating a class that computes remainder of the division 
    /// </summary>
    class RemainderOfTheDivision : ICalculator
    {
        public double Calculate(double first, double second)
        {
            return first % second;
        }
    }
}
