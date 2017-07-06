using System;

namespace calculator.OneArgument
{
    /// <summary>
    /// Cosinus computation 
    /// </summary>
    class Cosinus : ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
