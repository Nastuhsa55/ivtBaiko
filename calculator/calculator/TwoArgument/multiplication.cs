namespace calculator
{
    public class Multiplication: ICalculator 
    {
        public double Calculate (double first, double second)
        {
            return first * second;
        }
    }
}
