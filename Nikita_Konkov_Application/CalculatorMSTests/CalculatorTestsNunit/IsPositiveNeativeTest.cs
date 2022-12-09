global using CSharpCalculator;

namespace CalculatorTestsNunit
{
    [TestFixture]
    public class IsPositiveNeativeTest
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void IsPosNegTest()
        {
            Assert.That(_calculator.isPositive(-15), Is.EqualTo(false));
        }
    }
}
