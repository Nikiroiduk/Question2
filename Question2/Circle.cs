using System.Drawing;
using System.Formats.Asn1;

namespace Question2;

public class Circle : Figure
{
    public Circle(Point XY, double r) : base(XY, () => Math.PI * Math.Pow(r, 2))
    {
        if (r > 0) 
            this.r = r;
        else
            throw new ArgumentOutOfRangeException(nameof(r), $"Радиус должен быть больше 0!");
    }

    private readonly double r;

    public override double GetArea()
    {
        return Area;
    }
}
