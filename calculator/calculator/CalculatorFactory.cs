using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
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

                default:
                    throw new Exception();
            }

        }
    }
}
