using System;

namespace calculator.OneArgument
{
    /// <summary>
    /// Create a class that computes the cosine 
    /// </summary>
    class HyperbolicCosine : ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Cosh(first);
        }
    }
}
