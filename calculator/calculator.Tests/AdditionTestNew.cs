using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace calculator.Tests
{
    class AdditionTestNew
    {
        [TestCase(0, 0, 0)]
        [TestCase(2, 4, 6)]
        [TestCase(-1, -2, -3)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Addition();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
}
