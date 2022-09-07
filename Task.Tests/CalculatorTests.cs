using NUnit.Framework;

namespace Task.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator? calculator;

        [OneTimeSetUp]
        public void Initialize()
        {
            calculator = new Calculator();
        }

        [TestCase(1, 1, 2)]
        [TestCase(2, 8, 10)]
        [TestCase(10, 11, 21)]
        public void Additional_MustReturnCorrectValue(int a, int b, int expected)
        {
            int actual = calculator.Additional(a, b);

            Assert.AreEqual(actual, expected, $"Сложение {a} и {b} - Результат {actual} не равен {expected}");
        }

        [TestCase(1, 1, 0)]
        [TestCase(2, 8, -6)]
        [TestCase(10, 11, -1)]
        public void Subtraction_MustReturnCorrectValue(int a, int b, int expected)
        {
            int actual = calculator.Subtraction(a, b);

            Assert.AreEqual(actual, expected, $"Вычитание {a} и {b} - Результат {actual} не равен {expected}");
        }

        [TestCase(1, 1, ExpectedResult = 1)]
        [TestCase(2, 8, ExpectedResult = 16)]
        [TestCase(10, 11, ExpectedResult = 110)]
        public int Miltiplication_MustReturnCorrectValue(int a, int b)
        {
            int actual = calculator.Miltiplication(a, b);

            return actual;
        }

        [TestCase(4, 2, ExpectedResult = 2)]
        [TestCase(15, 5, ExpectedResult = 3)]
        [TestCase(13, 7, ExpectedResult = 1)]
        public int Division_MustReturnCorrectValue(int a, int b)
        {
            int actual = calculator.Division(a, b);

            return actual;
        }

        [Test]
        public void Division_MustThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Division(12, 0));
        }
    }
}