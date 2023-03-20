using System;
using NUnit.Framework;

namespace Calculator.Tests
{
    public class OptionsManagerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddShouldAddsAAndB()
        {
            //Arrange
            double a = 25;
            double b = 2;
            string expectedResult = "25 + 2 = 27";

            //Act
            string actualResult = OptionsManager.Add(a, b);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void MultiplyShouldMultiplyAAndB()
        {
            //Arrange
            double a = 2;
            double b = 3;
            string expectedResult = "2 * 3 = 6";

            //Act
            string actualResult = OptionsManager.Multiply(a, b);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SubstractShouldSubtractsAAndB()

        {
            //Arrange
            double a = 25;
            double b = 2;
            string expectedResult = "25 - 2 = 23";

            //Act
            string actualResult = OptionsManager.Subtract(a, b);
        }

        [Test]
        public void DivideShouldDivideAndB()
        {
            //Arrange
            double a = 10;
            double b = 2;
            string expectedResult = "10 / 2 = 5";

            //Act
            string actualResult = OptionsManager.Divide(a, b);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void DivideShouldntDivideZero()
        {
            //Arrange
            double a = 2;
            double b = 0;
            string expectedResult = "Not Divisible by zero";

            //Act
            var ex = Assert.Throws<InvalidOperationException>(() => OptionsManager.Divide(a, b));
            //Assert
            Assert.AreEqual(expectedResult, ex.Message);
        }
        [Test]
        public void FindsMinimum()
        {
            //Arrange
            double a = 1;
            double b = -23;
            string expectedResult = "Max (1,-23) = -23";
            //Act
            string actualResult = OptionsManager.Add(a, b);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void FindsMaximum()
        {
            //Arrange
            double a = 1;
            double b = -23;
            string expectedResult = "Min (1,-23) = 1";
            //Act
            string actualResult = OptionsManager.Add(a, b);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
