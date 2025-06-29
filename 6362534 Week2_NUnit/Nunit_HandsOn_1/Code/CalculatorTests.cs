using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(-1, -1, -2)]
        [TestCase(0, 0, 0)]
        public void Add_ShouldReturnCorrectResult(int a, int b, int expected)
        {
            var result = _calculator.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Ignore("Test not implemented")]
        public void IgnoredTest()
        {
            Assert.Fail("This test is ignored.");
        }

        [TearDown]
        public void TearDown()
        {
            // Optional cleanup
        }
    }
}
