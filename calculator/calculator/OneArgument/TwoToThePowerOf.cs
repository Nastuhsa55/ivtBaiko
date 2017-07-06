using System;

namespace calculator
{
    /// <summary>
    /// Creating a class that computes the two to the power
    /// </summary>
    class TwoToThePowerOf : ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Pow(2, first);
        }
    }
}
