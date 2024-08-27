using FluentAssertions;

namespace MBShapeLib.Tests.Unit;

public class CircleTests {
    [Theory]
    [InlineData(1, 3.1416)]
    public void ShouldMatchArea(double radius, double expectedArea) {
        // Arrange
        IShape circle = new Circle(radius);

        // Act
        var area = circle.GetArea();

        // Assert
        area.Should().BeApproximately(expectedArea, .0001);
    }

    [Theory]
    [InlineData(1, true)]
    [InlineData(1000, true)]
    [InlineData(-1, false)]
    [InlineData(0, true)]
    public void ShouldBeValid(double radius, bool expectedValid) {
        // Arrange

        // Act
        var act = () => new Circle(radius);

        // Assert
        if (expectedValid) {
            act.Should().NotThrow();
            return;
        }
        act.Should().ThrowExactly<ArgumentOutOfRangeException>();
    }
}