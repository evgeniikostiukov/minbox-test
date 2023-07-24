using AreaCalculatorLib.Figures;
using AreaCalculatorLib.Interfaces;

namespace AreaCalculatorLib.Services;

public class ArbitraryService : IFigureService<Arbitrary>
{
    // Используется Формула площади Гаусса
    public double Calculate(Arbitrary figure)
    {
        double sum1 = 0;
        double sum2 = 0;

        for (var i = 0; i < figure.Vertices.Length - 1; i++)
        {
            var vertex = figure.Vertices[i];
            var nextVertex = figure.Vertices[i + 1];

            sum1 += vertex.X * nextVertex.Y;
            sum2 += vertex.Y * nextVertex.X;
        }

        return Math.Abs(sum1 - sum2) / 2;
    }
}