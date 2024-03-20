using ConsoleApp;
using FluentAssertions;

namespace AreaCalculatorTests;
public class CircleTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(500, 785_398.1)]
    public void AreaCalculator_CalculateCircleArea_ReturnDouble(int radius, double expected)
    {
        AreaCalculator areaCalculator = new AreaCalculator();
        double result = areaCalculator.CalculateCircleArea(radius);
        result.Should().BeApproximately(expected, 0.1F);
    }
    [Theory]
    [InlineData(-5)]
    public void AreaCalculator_CalculateCircleArea_ThrowArgumentException(int radius)
    {
        AreaCalculator areaCalculator = new AreaCalculator();
        var act = () => areaCalculator.CalculateCircleArea(radius);
        act.Should().Throw<ArgumentException>().WithMessage($"Radius must be a positive number. Provided radius: {radius}");
    }
}