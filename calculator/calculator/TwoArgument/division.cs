using System;

namespace calculator
{
    /// <summary>
    /// Creating a class that computes  division
    /// </summary>
    public class Division : ICalculator 
    {
        public double Calculate (double first, double second)
        { if (second == 0)
            {
                throw new Exception("\n error in division by zero");
            }
            return first / second;
        }
    }
}

