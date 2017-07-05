using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace calculator.Tests
{
    class SubtractionTestNew
    {
        [TestCase(4, 2, 2)]
        [TestCase(8, 4, 4)]
        [TestCase(-2, -2, 0)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Subtraction();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
