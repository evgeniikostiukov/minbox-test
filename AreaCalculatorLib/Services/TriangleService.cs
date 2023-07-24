using AreaCalculatorLib.Figures;
using AreaCalculatorLib.Interfaces;

namespace AreaCalculatorLib.Services;

internal class TriangleService : IFigureService<Triangle>
{
    public double Calculate(Triangle figure)
    {
        var halfP = (figure.A + figure.B + figure.C) / 2;
        return Math.Sqrt(halfP * (halfP - figure.A) * (halfP - figure.B) * (halfP - figure.C));
    }

    public bool IsRight(Triangle triangle) =>
        Math.Abs(Math.Pow(triangle.A, 2) + Math.Pow(triangle.B, 2) + Math.Pow(triangle.C, 2) -
                 Math.Pow(double.Max(triangle.A, double.Max(triangle.B, triangle.C)), 2) -
                 Math.Pow(double.Max(triangle.A, double.Max(triangle.B, triangle.C)), 2)) <= 1e-5;
}