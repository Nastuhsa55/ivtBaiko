using System;

namespace calculator
{
    class Square : ICanculator2
    {
        public double Calculate(double first)
        { return Math.Sqrt(first); }
    }
}
