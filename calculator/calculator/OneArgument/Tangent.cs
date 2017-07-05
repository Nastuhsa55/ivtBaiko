using System;

namespace calculator.OneArgument
{
    class Tangent: ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}
