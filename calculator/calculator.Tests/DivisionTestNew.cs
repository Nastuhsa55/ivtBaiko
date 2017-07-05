using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace calculator.Tests
{
    class DivisionTestNew
    {
        [TestCase(1, 2, 0.5)]
        [TestCase(8, 4, 2)]
        [TestCase(-2, -2, 1)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Division();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
