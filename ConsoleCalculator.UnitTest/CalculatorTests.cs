using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleCalculator.UnitTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_ReturnsDouble()
        {
            // Arrange
            CalculatorLibrary.Calculator calculatorInstance = new CalculatorLibrary.Calculator();
            System.Random random = new Random();
            double num1 = random.Next();
            double num2 = random.Next();

            // Act
            var result = calculatorInstance.add(num1, num2);

            // Assert
            Assert.AreEqual(result, (num1+ num2));

        }

        [TestMethod]
        public void Sub_ReturnsDouble()
        {
            // Arrange
            CalculatorLibrary.Calculator calculatorInstance = new CalculatorLibrary.Calculator();
            System.Random random = new Random();
            double num1 = random.Next();
            double num2 = random.Next();

            // Act
            var result = calculatorInstance.sub(num1, num2);

            // Assert
            Assert.AreEqual(result, (num1 - num2));

        }


        [TestMethod]
        public void Mul_ReturnsDouble()
        {
            // Arrange
            CalculatorLibrary.Calculator calculatorInstance = new CalculatorLibrary.Calculator();
            System.Random random = new Random();
            double num1 = random.Next();
            double num2 = random.Next();

            // Act
            var result = calculatorInstance.mul(num1, num2);

            // Assert
            Assert.AreEqual(result, (num1 * num2));

        }

        [TestMethod]
        public void Div_ReturnsDouble()
        {
            // Arrange
            CalculatorLibrary.Calculator calculatorInstance = new CalculatorLibrary.Calculator();
            System.Random random = new Random();
            double num1 = random.Next();
            double num2 = random.Next();

            // Act
            var result = calculatorInstance.div(num1, num2);

            // Assert
            Assert.AreEqual(result, (num1 / num2));

        }
    }
}