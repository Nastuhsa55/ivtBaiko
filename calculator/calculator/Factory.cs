using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Factory
    {
        public static ICanculator2 CreateCalculator(string name)
        {
            switch (name)
            {
                case "button5":
                    return new Sinus();
                case "button6":
                    return new Logarithm();
                case "button7":
                    return new TwoToThePowerOf();
                default:
                    throw new Exception();
            }

        }
    }
}
