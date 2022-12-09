global using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;
using System.Globalization;

namespace CalculatorMSTests
{
    [TestClass]
    public class PowPositiveTest
    {
        private Calculator _calculator;

        [TestInitialize]
        public void Start()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        [DataRow (3, 3)]
        public void PowPosTest(double value, double valuePow)
        {
            Assert.AreEqual(9, _calculator.Multiply(value, valuePow));
        }

    }
}
