using AreaCalculatorLib.Figures;

namespace AreaCalculatorLibUnitTests;

public class TriangleTests
{
    [Fact]
    public void CorrectArea()
    {
        const double a = 3;
        const double b = 4;
        const double c = 5;
        const int expected = 6;

        var triangle = new Triangle(a, b, c);

        var result = triangle.GetArea();

        Assert.Equal(expected, result);
    }

    [Fact]
    public void NotCorrectTriangle()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 5));
    }

    [Fact]
    public void IsRight()
    {
        const double a = 3;
        const double b = 4;
        const double c = 5;

        var triangle = new Triangle(a, b, c);

        var result = triangle.IsRight();

        Assert.True(result);
    }

    [Fact]
    public void IsNotRight()
    {
        const double a = 3;
        const double b = 4;
        const double c = 6;

        var triangle = new Triangle(a, b, c);

        var result = triangle.IsRight();

        Assert.False(result);
    }
}