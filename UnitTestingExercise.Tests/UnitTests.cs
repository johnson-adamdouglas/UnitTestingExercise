using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var iAddThings = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = iAddThings.Add(num1, num2, num3);
            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, 15, 5)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var iSubtractThings = new Calculator();
            //Act
            var acutal = iSubtractThings.Subtract(minuend, subtrhend);
            //Assert
                Assert.Equal(expected, acutal);
        }

        [Theory]
        [InlineData(5, 10, 50)]//Add test data <-------
        [InlineData(5, 5, 25)]
        [InlineData(8, 5, 40)]
        [InlineData(6, 10, 60)]
        [InlineData(2, 8, 16)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var iMultiplyThings = new Calculator();
            //Act
            var actual = iMultiplyThings.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(50, 10, 5)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var iDivideThings = new Calculator();
            //Act
            var actual = iDivideThings.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
