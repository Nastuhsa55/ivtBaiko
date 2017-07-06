using System;

namespace calculator.OneArgument
{
    /// <summary>
    /// Creating a class that computes the module
    /// </summary>
    class ModuleOfX : ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Abs(first);
        }
    }
}
