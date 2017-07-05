namespace calculator
{
    class RemainderOfTheDivision : ICalculator
    {
        public double Calculate(double first, double second)
        {
            return first % second;
        }
    }
}
