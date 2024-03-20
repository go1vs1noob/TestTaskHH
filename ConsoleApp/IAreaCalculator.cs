namespace ConsoleApp;

// We don't know exact implementation of classes/structs our clients use. Better make a "service"
// which just takes simple parameters and doesn't know anything about implementations.
public interface IAreaCalculator
{
    public double CalculateTriangleArea(double side1, double side2, double side3);
    public double CalculateCircleArea(double radius);
}
