global using CSharpCalculator;

namespace CalculatorTestsNunit
{
    [TestFixture]
    public class IsPositivePositiveTest
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void IsPositivePosTest()
        {
            Assert.That(_calculator.isPositive(15), Is.EqualTo(true));
        }
    }
}