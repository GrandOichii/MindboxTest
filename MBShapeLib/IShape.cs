namespace MBShapeLib;

/// <summary>
/// Shape interface
/// </summary>
public interface IShape {
    /// <summary>
    /// Calculate area of the shape
    /// </summary>
    /// <returns>Area of the shape</returns>
    public double GetArea();
    /// <summary>
    /// Calculate perimeter of the shape
    /// </summary>
    /// <returns>Perimeter of the shape</returns>
    public double GetPerimeter();
}