using System;

namespace calculator
{
    class Sinus : ICanculator2
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}
