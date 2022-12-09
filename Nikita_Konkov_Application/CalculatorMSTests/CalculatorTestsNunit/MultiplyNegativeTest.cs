using NUnit.Framework;

namespace CalculatorTestsNunit
{
    [TestFixture]
    public class MultiplyNegativeTest
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        [TestCase(12, -17)] // dont't know how to do parametrized Test, please help 
        public void MultyNegTest()
        {

        }
    }
}
