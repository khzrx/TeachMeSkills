using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home11
{
    internal class CalculatorSumTests
    {
        Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("SetUp for CalculatorSumTests.");
            calculator = new Calculator();
        }

        [Test]
        [Category("Sum")]
        [Description("Retry attribute")]
        [Retry(5)]
        public void SummWithRetries()
        {
            var random = new Random();
            var expected = 4;
            var actual = calculator.Sum(random.NextInt64(0, 5), random.NextInt64(0, 5));

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [Category("Sum")]
        [Description("Random attribute")]
        public void SummTestRandomRepetead(
            [Random(0, 10, 5)] double operand1,
            [Random(0, 10, 5)] double operand2)
        {
            var expected = 4;
            var actual = calculator.Sum(operand1, operand2);

            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        [Category("Sum")]
        [Description("Values attribute")]
        public void SummTestRandom(
            [Values(1, 2, 3)] double operand1,
            [Random(0, 4, 5)] double operand2)
        {
            var expected = 4;
            var actual = calculator.Sum(operand1, operand2);

            Assert.That(actual, Is.EqualTo(expected));

        }

        [TestCase(-4, -2, -2)]
        [TestCase(4, -1, 5)]
        [TestCase(-4, -4, 0)]
        [Category("Sum")]
        [Description("TestCase attribute")]
        public void SummNegativeNumbersTestCases(double expected, double operand1, double operand2)
        {
            Assert.That(
                calculator.Sum(operand1, operand2),
                Is.EqualTo(expected));
        }

        [Test]
        [Category("Sum")]
        [Description("Range attribute")]
        public void SummTestRange(
            [Range(1, 4, 1)] double operand1,
            [Range(5, 8, 1)] double operand2)
        {
            var expected = operand1 + operand2;
            var actual = calculator.Sum(operand1, operand2);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("TearDown for CalculatorSumTests.");
        }
    }
}
