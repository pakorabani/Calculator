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
            Assert.AreEqual(expectedResult,ex.Message);
        }
    }
}