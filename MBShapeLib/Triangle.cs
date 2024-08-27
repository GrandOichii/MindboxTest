namespace MBShapeLib;

public class Triangle : IShape
{
    /// <summary>
    /// Triangle sides
    /// </summary>
    private readonly double[] _sides;

    public Triangle(double AB, double BC, double AC) {
        if (
            AB + BC <= AC ||
            AB + AC <= BC ||
            BC + AC <= AB
        ) throw new ArgumentException($"Sides {AB}, {BC} and {AC} can't create a valid triangle");

        _sides = [AB, BC, AC];
    }

    public double GetPerimeter() {
        return _sides.Aggregate(
            (side, result) => result + side
        );
    }

    public double GetArea()
    {
        double p = GetPerimeter() / 2;
        var inner = p;
        foreach (var side in _sides)
            inner *= p - side;

        return Math.Sqrt(inner);
    }

    /// <summary>
    /// Check whether the triangle is a right triangle or not
    /// </summary>
    /// <param name="precision">Precision point</param>
    /// <returns>True if the triangle of right, otherwise false</returns>
    public bool IsRight(double precision = .0000001) {
        var maxIdx = _sides.ToList().IndexOf(_sides.Max());
        var idx1 = (maxIdx + 1) % _sides.Length;
        var idx2 = (maxIdx + 2) % _sides.Length;
        
        double diff = _sides[maxIdx] * _sides[maxIdx] - _sides[idx1] * _sides[idx1] - _sides[idx2] * _sides[idx2];
        return Math.Abs(diff) < precision;
    }
}
