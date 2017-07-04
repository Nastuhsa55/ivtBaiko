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
                case "button1":
                    return new Addition();

                case "button2":
                    return new Subtraction();

                case "button3":
                    return new Multiplication();

                case "button4":
                    return new Division();

                default:
                    throw new Exception();
            }

        }
    }
}
