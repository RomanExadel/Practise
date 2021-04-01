using Calculator;
using Xunit;
using System;

namespace UnitTests.Algorithms
{
    public class ReversePolishNotationAlgorithmTest
    {
        [Fact]
        public void Algorithm_ValidInstruction_ReturnsCorrectResult()
        {
            //Arrange
            var expectedOutput = -9.01;
            var input = "-1.1+1.1*1.9-10*1.1/1.1=";
            var notationAlgorithm = new ReversePolishNotationAlgorithm();

            //Act
            var result = notationAlgorithm.Algorithm(input);

            //Assert
            Assert.Equal(expectedOutput, result);
        }

        [Fact]
        public void Algorithm_InvalidInstruction_ThowenArgumentException()
        {
            //Arrange
            var expectedOutput = "Invalid input";
            var input = "a * a=";
            var notationAlgorithm = new ReversePolishNotationAlgorithm();

            //Act
            var result = Assert.Throws<ArgumentException>(() => notationAlgorithm.Algorithm(input));

            //Assert
            Assert.Equal(expectedOutput, result.Message);
        }

        [Fact]
        public void Algorithm_ZeroDivision_ThowenDivideByZeroException()
        {
            //Arrange
            var expectedOutput = "Result is infinity";
            var input = "5/0=";
            var notationAlgorithm = new ReversePolishNotationAlgorithm();

            //Act
            var result = Assert.Throws<DivideByZeroException>(() => notationAlgorithm.Algorithm(input));

            //Assert
            Assert.Equal(expectedOutput, result.Message);
        }
    }
}
