using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home11
{
    internal class CalculatorMultiplyTests
    {
        Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("SetUp for CalculatorMultiplyTests.");
            calculator = new Calculator();
        }

        [Test]
        [Category("Multiply")]
        [Description("Retry attribute")]
        [Retry(5)]
        public void MultiplyWithRetries()
        {
            var random = new Random();
            var expected = 0;
            var actual = calculator.Multiply(random.NextInt64(0, 5), random.NextInt64(0, 5));

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [Category("Multiply")]
        [Description("Random attribute")]
        public void MultiplyTestRandomRepetead(
            [Random(1, 5, 3)] double operand1,
            [Random(1, 5, 3)] double operand2)
        {
            var expected = 4;
            var actual = calculator.Multiply(operand1, operand2);

            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        [Category("Multiply")]
        [Description("Values attribute")]
        public void MultiplyTestRandom(
            [Values(1, 2, 3)] double operand1,
            [Random(0, 10, 5)] double operand2)
        {
            var expected = 4;
            var actual = calculator.Multiply(operand1, operand2);

            Assert.That(actual, Is.EqualTo(expected));

        }

        [TestCase(0, -1, 0)]
        [TestCase(-1, -1, 1)]
        [TestCase(-10, -10, 100)]
        [Category("Multiply")]
        [Description("TestCase attribute")]
        public void MultiplyNegativeNumbersTestCases(double operand1, double operand2, double expected)
        {
            Assert.That(
                calculator.Multiply(operand1, operand2),
                Is.EqualTo(expected));
        }

        [Test]
        [Category("Multiply")]
        [Description("Range attribute")]
        public void MultiplyTestRange(
            [Range(1, 4, 1)] double operand1,
            [Range(5, 8, 1)] double operand2)
        {
            var expected = operand1 * operand2;
            var actual = calculator.Multiply(operand1, operand2);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("TearDown for CalculatorMultiplyTests.");
        }
    }
}
