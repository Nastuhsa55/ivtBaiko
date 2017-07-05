using System;

namespace calculator.OneArgument
{
    class Cosinus : ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
