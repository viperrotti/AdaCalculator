namespace AdaCalculator.Tests
{
    public class AdaCalculatorTest
    {
        [Fact]
        public void Sum_TwoNumbers_ShouldBeCorrect()
        {
            //Arrange
            var sut = new Calculator();

            //Act
            var result = sut.Calculate("sum", 4.0, 8.0);

            //Assert
            Assert.Equal(12.0, result.result);
            Assert.Equal("sum", result.operation);
        }
        [Fact]
        public void Subtract_TwoNumbers_ShouldBeCorrect()
        {
            //Arrange
            var sut = new Calculator();

            //Act
            var result = sut.Calculate("subtract", 7.0, 2.2);

            //Assert
            Assert.Equal(4.8, result.result);
            Assert.Equal("subtract", result.operation);
        }
        [Fact]
        public void Multiply_TwoNumbers_ShouldBeCorrect()
        {
            //Arrange
            var sut = new Calculator();

            //Act
            var result = sut.Calculate("multiply", 2.2, 3.4);

            //Assert
            Assert.Equal(7.48, result.result);
            Assert.Equal("multiply", result.operation);
        }
        [Fact]
        public void Divide_TwoNumbers_ShouldBeCorrect()
        {
            //Arrange
            var sut = new Calculator();

            //Act
            var result = sut.Calculate("divide", 10.0, 3.0);

            //Assert
            Assert.Equal(3.33, result.result);
            Assert.Equal("divide", result.operation);
        }

        [Fact]
        public void Divide_ByZero_ShouldResultInfinity()
        {
            //Arrange
            var sut = new Calculator();

            //Act
            var result = sut.Calculate("divide", 3.1, 0.0);

            //Assert
            Assert.Equal(double.PositiveInfinity, result.result);
            Assert.Equal("divide", result.operation);
        }
    }
}