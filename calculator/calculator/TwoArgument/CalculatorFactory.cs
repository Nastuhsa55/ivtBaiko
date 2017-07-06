using System;

namespace calculator
{
    /// <summary>
    /// Creating a class that groups methods
    /// </summary>
    public class CalculatorFactory
    {
        public static ICalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "plus":
                    return new Addition();

                case "minus":
                    return new Subtraction();

                case "multiplication":
                    return new Multiplication();

                case "division":
                    return new Division();
                case "RemainderOfTheDivision":
                    return new RemainderOfTheDivision ();
                default:
                    throw new Exception();
            }

        }
    }
}
