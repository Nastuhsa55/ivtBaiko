using System;

namespace calculator.OneArgument
{
    /// <summary>
    /// Creating form that calculates the decimal logarithm 
    /// </summary>
    class DecimalLogarithm : ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Log10(first);
        }
    }
}
