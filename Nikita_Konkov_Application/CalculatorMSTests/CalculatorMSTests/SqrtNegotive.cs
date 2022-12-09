global using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace CalculatorMSTests
{
    [TestClass]
    public class SqrtNegotive
    {
        Calculator calculator = new Calculator();

        [TestMethod]
        public void SqrtNegTest()
        {
            Assert.AreEqual("Error message: Invalid number", calculator.Sqrt(-2));
        }
    }
}
