using System;

namespace calculator
{
    /// <summary>
    /// Creating a class that computes x to the power of two
    /// </summary>
    class XToThePowerOfTwo : ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Pow( first,2);
        }
    }
}
