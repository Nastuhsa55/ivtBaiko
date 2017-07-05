using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace calculator.Tests
{
    class MultiplicationTestNew
    {
        [TestCase(4, 2, 8)]
        [TestCase(8, 4, 32)]
        [TestCase(-2, -2, 4)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Multiplication();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
