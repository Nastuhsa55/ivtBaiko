using System;

namespace calculator
{
    /// <summary>
    /// Create a class that computes the square
    /// </summary>
    class Square : ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}
