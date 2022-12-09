using CSharpCalculator;

namespace CalculatorMSTests
{
[TestClass]
    public class SqrtPosTest
    {
        Calculator calculator = new Calculator();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, calculator.Sqrt(9));
        }
    }
}