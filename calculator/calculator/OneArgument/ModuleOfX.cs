using System;

namespace calculator.OneArgument
{
    /// <summary>
    /// Create a class that computes the module
    /// </summary>
    class ModuleOfX : ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Abs(first);
        }
    }
}
