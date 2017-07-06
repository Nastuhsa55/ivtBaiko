using System;

namespace calculator
{
    /// <summary>
    /// Creating a class that computes the logarithm
    /// </summary>
    class Logarithm : ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}
