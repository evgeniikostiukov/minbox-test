using AreaCalculatorLib.Figures.Base;

namespace AreaCalculatorLib.Interfaces;

internal interface IFigureService<in TFigure> where TFigure : Figure
{
    double Calculate(TFigure figure);
}