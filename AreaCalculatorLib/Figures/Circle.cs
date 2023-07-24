using AreaCalculatorLib.Figures.Base;
using AreaCalculatorLib.Services;

namespace AreaCalculatorLib.Figures;

public class Circle : Figure
{
    public Circle(double radius)
    {
        Radius = radius;

        Validate();
    }

    public double Radius { get; }

    protected sealed override void Validate()
    {
        if (Radius < 0) throw new ArgumentException("Radius cannot be less 0");
    }

    public override double GetArea()
    {
        var service = new CircleService();
        return service.Calculate(this);
    }
}