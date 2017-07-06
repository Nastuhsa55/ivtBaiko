using System;

namespace calculator
{
    /// <summary>
    /// Creating a class that computes the square
    /// </summary>
    class Square : ICanculator2
    {
        public double Calculate(double first)
        {
            if (first < 0)
            {
                throw new Exception("\n It is impossible to extract a root from a negative number");
            }
            return Math.Sqrt(first);
        }
    }
}
