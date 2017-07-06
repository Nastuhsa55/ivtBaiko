using System;

namespace calculator.OneArgument
{
    /// <summary>
    /// Create a class that computes the tangent 
    /// </summary>
    class Tangent : ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}
