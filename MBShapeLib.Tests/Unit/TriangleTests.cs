namespace MBShapeLib.Tests.Unit;

using FluentAssertions;
using MBShapeLib;

public class TriangleTests {
    [Theory]
    [InlineData(new double[] {1, 1, 1}, true)]
    [InlineData(new double[] {3, 4, 5}, true)]
    [InlineData(new double[] {5, 5, 15}, false)]
    [InlineData(new double[] {2, 1, 1}, false)]
    public void ShouldBeValid(double[] sides, bool expectedValid) {
        // Act
        var act = () => new Triangle(sides[0], sides[1], sides[2]);

        // Assert
        if (expectedValid) {
            act.Should().NotThrow();
            return;
        }
        act.Should().Throw<ArgumentException>();

    }
    [Theory]
    [InlineData(new double[] {1, 1, 1}, .433)]
    [InlineData(new double[] {2, 2, 2}, 1.732)]
    [InlineData(new double[] {3, 4, 5}, 6)]
    public void ShouldMatchArea(double[] sides, double expectedArea) {
        // Arrange
        IShape triangle = new Triangle(sides[0], sides[1], sides[2]);

        // Act
        var area = triangle.GetArea();

        // Assert
        area.Should().BeApproximately(expectedArea, .0001);
    }

    [Theory]
    [InlineData(new double[] {3, 4, 5}, true)]
    [InlineData(new double[] {1, 1, 1}, false)]
    public void ShouldBeRight(double[] sides, bool expectedIsRight) {
        // Arrange
        var triangle = new Triangle(sides[0], sides[1], sides[2]);

        // Act
        var isRight = triangle.IsRight();

        // Arrange
        isRight.Should().Be(expectedIsRight);
    }
}