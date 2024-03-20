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
        if (!IsTrianglePossible(side1, side2, side3))
        {
            throw new ArgumentException($"Your triangle is impossible! Provided sides: ({side1},{side2},{side3})");
        }
        double halfPerimeter = (side1 + side2 + side3) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));
    }

    // Might as well check and throw an exception
    private bool IsTrianglePossible(double side1, double side2, double side3)
    {
        return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
    }

    // Hmm... Why do we need that? Maybe we save some time not calculating square root?... If we check each triangle for that we might not save any time.
    // Anyway, let's implement it since we were asked! Maybe other developer on our team requested it for his method!
    private bool IsTriangleRightangled(double side1, double side2, double side3)
    {
        double[] sides = { side1, side2, side3 };
        Array.Sort(sides);
        return Math.Pow(sides[2], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2);
    }
}