﻿namespace calculator
{
    class Addition : ICalculator 
    {
        public double Calculate (double first,double second) 
        {
            return first + second;
        }
    }
}