
namespace CalculatorApp.Tests;

public class CalculatorTests
{
    Calculator _calculator;

    public CalculatorTests()
    {
        _calculator = new Calculator();
    }

    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
    {
        //  Arrange
        var calculator = new Calculator();
        var n1 = 100;
        var n2 = 200;
        var expected = n1 + n2;

        // Act
        int result = calculator.Add(n1, n2);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Add_TwoLargeNumbers_ReturnsCorrectSum()
    {
        //  Arrange
        var calculator = new Calculator();
        var n1 = int.MaxValue;

        // Act
        int result = calculator.Add(n1, 1);

        // Assert
        Assert.Equal(int.MinValue, result);
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(2, 0, 0)]
    [InlineData(2, 30, 60)]
    [InlineData(2, -1, -2)]
    [InlineData(2, -3, -6)]
    public void Sum_TwoNumbers_ReturnsCorrectProduct(int n1, int n2, int expected)
    {
        var actual = _calculator.Multiply(n1, n2);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Divide_DivisionByZero_ThrowsException()
    {
        var calculator = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(12, 0));
    }
}