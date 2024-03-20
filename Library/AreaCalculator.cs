namespace ConsoleApp;

public class AreaCalculator : IAreaCalculator
{
    public double CalculateCircleArea(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException($"Radius must be a positive number. Provided radius: {radius}");
        }
        return Math.PI * Math.Pow(radius, 2);
    }

    public double CalculateTriangleArea(double side1, double side2, double side3)
    {
        if (!TriangleEvaluator.IsTrianglePossible(side1, side2, side3))
        {
            throw new ArgumentException($"Your triangle is impossible! Provided sides: ({side1},{side2},{side3})");
        }
        double halfPerimeter = (side1 + side2 + side3) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));
    }
}
