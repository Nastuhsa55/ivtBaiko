using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace calculator.Tests
{
    class FactoryTest
    {
        [TestCase("plus", typeof(Addition))]
        [TestCase("minus", typeof(Subtraction))]
        [TestCase("multiplication", typeof(Multiplication))]
        [TestCase("division", typeof(Division))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = CalculatorFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
