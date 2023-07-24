using AreaCalculatorLib.Figures;
using AreaCalculatorLib.Services;

namespace AreaCalculatorLibUnitTests;

public class ArbitaryTests
{
    [Fact]
    public void Correct4Vertices()
    {
        var arbitraryFigure = new Arbitrary(new[]
        {
            new Vertex(1, 2),
            new Vertex(3, 5),
            new Vertex(4, 2),
            new Vertex(2, 1)
        });

        const int expected = 6;

        var arbitraryService = new ArbitraryService();

        var result = arbitraryService.Calculate(arbitraryFigure);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Correct7Vertices()
    {
        var arbitraryFigure = new Arbitrary(new[]
        {
            new Vertex(10, 15),
            new Vertex(20, 15),
            new Vertex(30, 40),
            new Vertex(40, 33),
            new Vertex(43, 28.5),
            new Vertex(30, 18.2),
            new Vertex(15, 10),
        });

        var expected = 304.7;
        
        var arbitraryService = new ArbitraryService();

        var result = arbitraryService.Calculate(arbitraryFigure);

        Assert.Equal(expected, result, 7);
    }
    
    [Fact]
    public void CorrectNegativeVertices()
    {
        var arbitraryFigure = new Arbitrary(new[]
        {
            new Vertex(-20, 15),
            new Vertex(-10, 15),
            new Vertex(0, 40),
            new Vertex(-5, 10),
        });

        var expected = 112.5;
        
        var arbitraryService = new ArbitraryService();

        var result = arbitraryService.Calculate(arbitraryFigure);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Less3Vertices()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            new Arbitrary(new[]
            {
                new Vertex(1, 1),
                new Vertex(2, 2)
            });
        });
    }
}