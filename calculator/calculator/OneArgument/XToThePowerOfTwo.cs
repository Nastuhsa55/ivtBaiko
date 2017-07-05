using System;

namespace calculator
{
    class XToThePowerOfTwo: ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Pow( first,2);
        }
    }
}
