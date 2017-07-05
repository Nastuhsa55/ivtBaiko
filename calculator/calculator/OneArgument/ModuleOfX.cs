using System;

namespace calculator.OneArgument
{
    class ModuleOfX : ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Abs(first);
        }
    }
}
