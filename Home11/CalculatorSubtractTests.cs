using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home11
{
    internal class CalculatorSubtractTests
    {
        Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("SetUp for CalculatorSubtractTests.");
            calculator = new Calculator();
        }

        [Test]
        [Category("Subtract")]
        [Description("Retry attribute")]
        [Retry(10)]
        public void SubtractWithRetries()
        {
            var random = new Random();
            var expected = -1;
            var actual = calculator.Subtract(random.NextInt64(0, 5), 1);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [Category("Subtract")]
        [Description("Random attribute")]
        public void SubtractTestRandomRepetead(
            [Random(1, 5, 3)] double operand1,
            [Random(1, 5, 3)] double operand2)
        {
            var expected = 0;
            var actual = calculator.Divide(operand1, operand2);

            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        [Category("Subtract")]
        [Description("Values attribute")]
        public void SubtractTestRandom(
            [Values(1, 2, 3)] double operand1,
            [Random(1, 3, 5)] double operand2)
        {
            var expected = 1;
            var actual = calculator.Subtract(operand1, operand2);

            Assert.That(actual, Is.EqualTo(expected));

        }

        [TestCase(0, -1, 1)]
        [TestCase(-1, -1, 0)]
        [TestCase(-20, -10, -10)]
        [Category("Subtract")]
        [Description("TestCase attribute")]
        public void SubtractNegativeNumbersTestCases(double operand1, double operand2, double expected)
        {
            Assert.That(
                calculator.Subtract(operand1, operand2),
                Is.EqualTo(expected));
        }

        [Test]
        [Category("Subtract")]
        [Description("Range attribute")]
        public void SubtractTestRange(
            [Range(1, 4, 1)] double operand1,
            [Range(5, 8, 1)] double operand2)
        {
            var expected = operand1 - operand2;
            var actual = calculator.Subtract(operand1, operand2);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("TearDown for CalculatorSubtractTests.");
        }
    }
}
