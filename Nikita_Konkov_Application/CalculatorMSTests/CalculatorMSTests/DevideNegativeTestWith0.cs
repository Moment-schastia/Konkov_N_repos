global using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace CalculatorMSTests
{
    [TestClass]
    public class DevideNegativeTestWith0
    {
        Calculator calculator = new Calculator();

        [TestMethod]
        public void DevideTestWith_0()
        {
            Assert.AreEqual(new DivideByZeroException("Attempted to divide by zero."), calculator.Divide(1.1, 0));
        }
    }
    
}
