using System;

namespace calculator.OneArgument
{
    /// <summary>
    /// Arctanget computation 
    /// </summary>
    class Arctangent : ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}
