using AreaCalculatorLib.Figures;

namespace AreaCalculatorLibUnitTests;

public class CircleTests
{
    [Fact]
    public void RadiusIs3()
    {
        const int r = 3;
        const double expected = 28.274333882308138;

        var circle = new Circle(r);

        var result = circle.GetArea();

        Assert.Equal(expected, result);
    }

    [Fact]
    public void RadiusIsNegative()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-3));
    }

    [Fact]
    public void RadiusIs0()
    {
        const int r = 0;
        const int expected = 0;

        var circle = new Circle(r);

        var result = circle.GetArea();

        Assert.Equal(expected, result);
    }
}