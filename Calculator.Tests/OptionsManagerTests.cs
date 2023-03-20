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
        public void DevideReminderShouldDevideAAndB()
        {
            //Arrange
            double a = 2;
            double b = 3;
            string expectedResult = "2 % 3 = 2";

            //Act
            string actualResult = OptionsManager.DevideReminder(a, b);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void PowerShouldReturnCorrectValuesForAAndB()
        {
            //Arrange
            double a = 2;
            double b = 3;
            string expectedResult = "2 ^ 3 = 8";

            //Act
            string actualResult = OptionsManager.Power(a, b);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void SQRTshouldAddPositives()
        {
            //Arrange
            double a = 4;
            double b = 4;
            string expectedResult = "Square root of 4 + square root of 4 = 4";

            //Act
            string actualResult = OptionsManager.SumSquareRoots(a, b);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void SQRTshouldntAddNegatives()
        {
            //Arrange
            double a = -4;
            double b = -4;
            string expectedResult = "The numbers must be positive or 0";

            //Act
            var ex = Assert.Throws<InvalidOperationException>(() => OptionsManager.SumSquareRoots(a, b));
            //Assert
            Assert.AreEqual(expectedResult, ex.Message);
        }
        [Test]
        public void FindsMinimum()
        {
            //Arrange
            double a = 1;
            double b = -23;
            string expectedResult = "Min (1,-23) = -23";
            //Act
            string actualResult = OptionsManager.Minimum(a, b);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void FindsMaximum()
        {
            //Arrange
            double a = 1;
            double b = -23;
            string expectedResult = "Max (1,-23) = 1";
            //Act
            string actualResult = OptionsManager.Maximum(a, b);
        }

        [Test]
        public void SQshouldAddAandB()
        {
            //Arrange
            double a = 4;
            double b = 4;
            string expectedResult = "4^2 + 4^2 = 32";

            //Act
            string actualResult = OptionsManager.SumSquares(a, b);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
