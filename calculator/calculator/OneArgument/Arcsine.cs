using System;

namespace calculator.OneArgument
{
    /// <summary>
    /// Arcsine computation 
    /// </summary>
    class Arcsine : ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Asin(first);
        }
    }
}
