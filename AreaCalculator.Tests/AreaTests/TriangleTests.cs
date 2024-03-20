using ConsoleApp;
using FluentAssertions;

namespace AreaCalculatorTests;
public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(5, 12, 13, 30)]
    [InlineData(696, 697, 985, 242556)]
    public void AreaCalculator_CalculateTriangleArea_ReturnDouble(int side1, int side2, int side3, double expected)
    {
        AreaCalculator areaCalculator = new AreaCalculator();
        double result = areaCalculator.CalculateTriangleArea(side1, side2, side3);
        result.Should().Be(expected);
    }
    [Theory]
    [InlineData(-6, -5, -4)]
    [InlineData(1, 1, 2)]
    [InlineData(1, 2, 4)]
    public void AreaCalculator_CalculateTriangleArea_ThrowArgumentException(int side1, int side2, int side3)
    {
        AreaCalculator areaCalculator = new AreaCalculator();
        var act = () => areaCalculator.CalculateTriangleArea(side1, side2, side3);
        act.Should().Throw<ArgumentException>().WithMessage($"Your triangle is impossible! Provided sides: ({side1},{side2},{side3})");
    }
}