using AreaCalculatorLib.Figures.Base;
using AreaCalculatorLib.Services;

namespace AreaCalculatorLib.Figures;

public class Arbitrary : Figure
{
    private readonly ArbitraryService _arbitraryService;

    public Arbitrary(IReadOnlyList<Vertex> vertices)
    {
        if (vertices.Count < 3)
        {
            throw new ArgumentException("The number of vertices must be greater than 3");
        }

        Vertices = vertices.Append(vertices[0]).ToArray();
        _arbitraryService = new ArbitraryService();
    }

    public Vertex[] Vertices { get; }

    protected override void Validate()
    {
    }

    public override double GetArea()
    {
        return _arbitraryService.Calculate(this);
    }
}