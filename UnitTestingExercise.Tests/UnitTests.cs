using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(10, 15, 5, 30)]
        [InlineData(100, 206, 21, 327)]
        [InlineData(-11, 6, -52, -57)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calculator = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calculator.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20,10, 10)]//Add test data <-------
        [InlineData(-46, 63, -109)]
        [InlineData(-7, 52, -59)]
        [InlineData(61, 23, 38)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,25)]    //Add test data <-------
        [InlineData(9, 81, 729)]
        [InlineData(-23, 4, -92)]
        [InlineData(100, 69, 6900)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10,5,2)]    //Add test data <-------
        [InlineData(78, 3, 26)]
        [InlineData(522, 2, 261)]
        [InlineData(2, 1, 2)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            var actual = calculator.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
