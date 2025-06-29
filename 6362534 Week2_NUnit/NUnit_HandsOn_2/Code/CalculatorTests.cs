using NUnit.Framework;
using CalcLibrary;
using System;

namespace CalcTests
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }


        [TestCase(5, 3, 2)]
        [TestCase(10, 4, 6)]
        [TestCase(100, 50, 50)]
        public void TestSubtraction(double a, double b, double expected)
        {
            double result = calc.Subtract(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(2, 3, 6)]
        [TestCase(5, 0, 0)]
        [TestCase(7, 4, 28)]
        public void TestMultiplication(double a, double b, double expected)
        {
            double result = calc.Multiply(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(10, 2, 5)]
        [TestCase(9, 3, 3)]
        public void TestDivision(double a, double b, double expected)
        {
            double result = calc.Divide(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestDivisionByZero()
        {
            try
            {
                double result = calc.Divide(10, 0);
                Assert.Fail("Division by zero");
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("Cannot divide by zero"));
            }
        }

        [Test]
        public void TestAddAndClear()
        {
            calc.Add(4, 6);
            Assert.That(calc.GetResult, Is.EqualTo(10));

            calc.AllClear();
            Assert.That(calc.GetResult, Is.EqualTo(0));
        }
    }
}
