using calculator.OneArgument;
using System;

namespace calculator
{
    class Factory
    {
        public static ICanculator2 CreateCalculator(string name)
        {
            switch (name)
            {
                case "sinus":
                    return new Sinus();
                case "logarithm":
                    return new Logarithm();
                case "TwoToThePowerOf":
                    return new TwoToThePowerOf();
                case "XToThePowerOfTwo":
                    return new XToThePowerOfTwo();
                case "Square":
                    return new Square();
                case "Cosinus":
                    return new Cosinus();
                case "Tandent":
                    return new Tangent();
                default:
                    throw new Exception();
            }

        }
    }
}
