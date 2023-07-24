using AreaCalculatorLib.Figures;
using AreaCalculatorLib.Interfaces;

namespace AreaCalculatorLib.Services;

internal class CircleService : IFigureService<Circle>
{
    public double Calculate(Circle figure) => Math.PI * Math.Pow(figure.Radius, 2);
}