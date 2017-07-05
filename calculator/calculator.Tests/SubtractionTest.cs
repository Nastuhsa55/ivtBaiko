using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace calculator.Tests
{
    [TestFixture]
    class SubtractionTest
    {
        [Test]
        public void CalculateTest()
        {
            ICalculator calculator = new Subtraction();
            double result = calculator.Calculate(6, 2);
            Assert.AreEqual(4, result);
        }
    }
}
