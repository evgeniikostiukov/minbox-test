using AreaCalculatorLib.Figures.Base;
using AreaCalculatorLib.Services;

namespace AreaCalculatorLib.Figures;

public class Triangle : Figure
{
    private readonly TriangleService _triangleService;
    
    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;

        Validate();

        _triangleService = new TriangleService();
    }

    public double A { get; }
    public double B { get; }
    public double C { get; }

    protected sealed override void Validate()
    {
        if (A + B < C || A + C < B || C + B < A) throw new ArgumentException("Triangle does not exist");
    }

    public override double GetArea()
    {
        return _triangleService.Calculate(this);
    }

    public bool IsRight()
    {
        return _triangleService.IsRight(this);
    }
}