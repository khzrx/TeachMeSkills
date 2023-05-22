using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home11
{
    internal class CalculatorDivideTests
    {
        Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("SetUp for CalculatorDivideTests.");
            calculator = new Calculator();
        }

        [Test]
        [Category("Divide")]
        [Description("Retry attribute")]
        [Retry(10)]
        public void DivideWithRetries()
        {
            var random = new Random();
            var expected = 0;
            var actual = calculator.Divide(random.NextInt64(0, 5), 1);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [Category("Divide")]
        [Description("Random attribute")]
        public void DivideTestRandomRepetead(
            [Random(1, 5, 3)] double operand1,
            [Random(1, 5, 3)] double operand2)
        {
            var expected = 1;
            var actual = calculator.Divide(operand1, operand2);

            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        [Category("Divide")]
        [Description("Values attribute")]
        public void DivideTestRandom(
            [Values(1, 2, 3)] double operand1,
            [Random(1, 3, 5)] double operand2)
        {
            var expected = 1;
            var actual = calculator.Divide(operand1, operand2);

            Assert.That(actual, Is.EqualTo(expected));

        }

        [TestCase(0, -1, 0)]
        [TestCase(-1, -1, 1)]
        [TestCase(-10, -10, 1)]
        [Category("Divide")]
        [Description("TestCase attribute")]
        public void DivideNegativeNumbersTestCases(double operand1, double operand2, double expected)
        {
            Assert.That(
                calculator.Divide(operand1, operand2),
                Is.EqualTo(expected));
        }

        [Test]
        [Category("Divide")]
        [Description("Range attribute")]
        public void DivideTestRange(
            [Range(1, 4, 1)] double operand1,
            [Range(5, 8, 1)] double operand2)
        {
            var expected = operand1 / operand2;
            var actual = calculator.Divide(operand1, operand2);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("TearDown for CalculatorDivideTests.");
        }
    }
}
