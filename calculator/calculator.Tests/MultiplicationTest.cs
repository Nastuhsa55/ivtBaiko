using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
 
namespace calculator.Tests
{
    [TestFixture]
    class MultiplicationTest
    {
        [Test]
        public void CalculateTest()
        {
            ICalculator calculator = new Multiplication();
            double result = calculator.Calculate(3, 2);
            Assert.AreEqual(6, result);
        }
    }
}
