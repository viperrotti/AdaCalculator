using Moq;

namespace AdaCalculator.Tests
{
    public class AdaCalculatorTest
    {
        [Fact]
        public void Calculate_SumTwoNumbers_ShouldSum()
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
        public void Calculate_SubtractTwoNumbers_ShouldSubtract()
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
        public void Calculate_MultiplyTwoNumbers_ShouldMultiply()
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
        public void Calculate_DivideTwoNumbers_ShouldDivide()
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
        public void Calculate_DivideByZero_ShouldResultInfinity()
        {
            //Arrange
            var sut = new Calculator();

            //Act
            var result = sut.Calculate("divide", 3.1, 0.0);

            //Assert
            Assert.Equal(double.PositiveInfinity, result.result);
            Assert.Equal("divide", result.operation);
        }

        [Fact]
        public void Calculate_DefaultOperation_ShouldSum()
        {
            //Arrange
            var sut = new Calculator();

            //Act
            var result = sut.Calculate("anyValue", 3.0, 2.0);

            //Assert
            Assert.Equal(5.0, result.result);
            Assert.Equal("anyValue", result.operation);
        }

        [Fact]
        public void CalculatorMachine_MockTest_ShouldReturnSum()
        {
            // Arrange
            Moq.Mock<ICalculator> mock = new Moq.Mock<ICalculator>();
            mock.Setup(x => x.Calculate(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns(("sum", 5.2));
            CalculatorMachine calcMach = new CalculatorMachine(mock.Object);
            // Act
            (string operation, double result) op = calcMach.Calculate("sum", 2.0, 3.2);
            // Assert
            Assert.Equal("sum", op.operation);
            Assert.Equal(5.2, op.result);
        }
    }
}