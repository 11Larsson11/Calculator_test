using Lexicon3;
using System;
using Xunit;

namespace Calculator_test.TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void DivideByZero()
        {
            double num1 = 1;
            double num2 = 0;
            double expectedResults = 0;   //When dividing by zero, the method returns 0

            double result = Program.Divide(num1, num2);

            Assert.Equal(expectedResults, result, 1);
        }

        [Fact]

        public void DivisionTest()
        {
            double num1 = 18.6;
            double num2 = 3.2;
            double expectedResults = 5.8125;

            double result = Program.Divide(num1, num2);

            Assert.Equal(expectedResults, result, 4);
        }

        [Fact]
        public void AdditionTest()
        {
            double num1 = 1;
            double num2 = 23.4;
            double expectedResults = 24.4;

            double result = Program.Adding(num1, num2);

            Assert.Equal(expectedResults, result, 1);
        }

        [Fact]
        public void MatrixAdditionTest()
        {
            int num1 = 1;
            double num2 = 2.18;
            double expectedResults = 3.18;

            double result = Program.Adding(num1, num2);

            Assert.Equal(expectedResults, result, 2);
        }

        [Fact]
        public void SubtractionTest()
        {
            double num1 = 1;
            double num2 = 23.4;
            double expectedResults = -22.4;

            double result = Program.Subtracting(num1, num2);

            Assert.Equal(expectedResults, result, 1);
        }

        [Fact]

        public void MatrixSubtractionTest()
        {
            int num1 = 1;
            double num2 = 23.4;
            double expectedResults = -22.4;

            double result = Program.Subtracting(num1, num2);

            Assert.Equal(expectedResults, result, 1);
        }

        [Fact]

        public void MultiplicationTest()
        {
            double num1 = 3.6;
            double num2 = 1.2;
            double expectedResults = 4.32;

            double result = Program.Multiply(num1, num2);

            Assert.Equal(expectedResults, result, 2);
        }
    }
}
