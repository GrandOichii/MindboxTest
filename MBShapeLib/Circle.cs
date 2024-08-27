namespace MBShapeLib;

/// <summary>
/// Circle shape
/// </summary>
public class Circle : IShape {
    /// <summary>
    /// Circle radius
    /// </summary>
    private readonly double _radius;

    public Circle(double radius) {
        if (radius < 0)
            throw new ArgumentOutOfRangeException($"Circle radius can't be less than 0 ({radius})");

        _radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * _radius; 
    }
}