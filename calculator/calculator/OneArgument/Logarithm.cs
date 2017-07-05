using System;

namespace calculator
{
    class Logarithm : ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}
