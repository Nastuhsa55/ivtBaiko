using System;

namespace calculator
{
    class TwoToThePowerOf : ICanculator2
    {
        public double Calculate(double first)
        { return Math.Pow(2,first); }
    }
}
