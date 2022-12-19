global using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace CalculatorMSTests
{
    [TestClass]
    public class DevideTests
    {
        Calculator calculator = new Calculator();
        
        [TestMethod]
        public void DevidePosTest()
        {
            Assert.AreEqual(2.5238095238095237, calculator.Divide(5.3, 2.1));
        }



    }
}
