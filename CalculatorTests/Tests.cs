using Lab_1;

namespace CalculatorTests
{
    [TestFixture]
    public class Tests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new();
        }

        [Test]
        public void AddTwoNumberReturnsSum()
        {
            double a = 4;
            double b = 5;
            double result = 9;

            Assert.That(result, Is.EqualTo(calculator.Add(a, b)));
        }

        [Test]
        public void SubtractTwoNumberReturnsDifference()
        {
            double a = 10;
            double b = 5;
            double result = 5;

            Assert.That(result, Is.EqualTo(calculator.Subtract(a, b)));
        }

        [Test]
        public void MultiplyTwoNumberReturnsProduct()
        {
            double a = 7;
            double b = 5;
            double result = 35;

            Assert.That(result, Is.EqualTo(calculator.Multiply(a, b)));
        }

        [Test]
        public void DivideByZeroReturnsInfinity()
        {
            double a = 5;
            double b = 0;

            bool result = double.IsInfinity(calculator.Divide(a, b));

            Assert.That(result, Is.True);
        }

        [Test]
        public void DivideZeroByZeroReturnsNaN()
        {
            double a = 0;
            double b = 0;

            bool result = double.IsNaN(calculator.Divide(a, b));

            Assert.That(result, Is.True);
        }

        [Test]
        public void DivideByZeroReturnsNumber()
        {
            double a = 24;
            double b = 6;
            double result = 4;

            Assert.That(result, Is.EqualTo(calculator.Divide(a, b)));
        }

    }
}
