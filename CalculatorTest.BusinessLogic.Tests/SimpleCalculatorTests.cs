using NUnit.Framework;

namespace CalculatorTest.BusinessLogic.Tests
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        private ISimpleCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new SimpleCalculator();
        }

        [Test]
        [TestCase(1, 1, 2)]
        [TestCase(15, 20, 35)]
        [TestCase(1, -1, 0)]
        [TestCase(-1, -1, -2)]
        [TestCase(-1, 1, 0)]
        [TestCase(1, 0, 1)]
        [TestCase(-1, 0, -1)]
        [TestCase(-1, null, -1)]
        [TestCase(null, 1, 1)]
        [TestCase(null, null, 0)]
        public void CanAdd(int start, int amount, int expectedOutcome)
        {
            //  Act
            var result = _calculator.Add(start, amount);

            //  Assert
            Assert.That(result, Is.EqualTo(expectedOutcome));
        }

        [Test]
        [TestCase(1, 1, 0)]
        [TestCase(15, 20, -5)]
        [TestCase(1, -1, 2)]
        [TestCase(-1, -1, 0)]
        [TestCase(-1, 1, -2)]
        [TestCase(1, 0, 1)]
        [TestCase(-1, 0, -1)]
        [TestCase(-1, null, -1)]
        [TestCase(null, 1, -1)]
        [TestCase(null, null, 0)]
        public void CanSubtract(int start, int amount, int expectedOutcome)
        {
            //  Act
            var result = _calculator.Subtract(start, amount);

            //  Assert
            Assert.That(result, Is.EqualTo(expectedOutcome));
        }
    }
}