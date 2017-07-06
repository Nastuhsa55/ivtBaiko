using System;

namespace calculator
{
    /// <summary>
    /// Create a class that computes the logarithm
    /// </summary>
    class Logarithm : ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}
