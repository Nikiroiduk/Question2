using System.Drawing;
using System.Linq.Expressions;

namespace Question2;

public abstract class Figure
{
    private Point XY;
    private readonly double area;
    public double Area => area;
    protected Figure(Point XY, Expression<Func<double>> expr)
    {
        this.XY = XY;
        this.area = expr.Compile()();
    }
    public abstract double GetArea();

    public override string ToString()
    {
        return $"{Area}";
    }
}
