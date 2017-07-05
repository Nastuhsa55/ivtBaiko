using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace calculator.Tests
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void CalculateTest()
        {
            ICalculator calculator = new Division();
            double result = calculator.Calculate(1, 2);
            Assert.AreEqual(0.5, result);
        }

    }

}
