using System;

namespace calculator
{
    /// <summary>
    /// Creating a class that computes the sinus 
    /// </summary>
    class Sinus : ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}
