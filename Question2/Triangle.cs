using System.Drawing;

namespace Question2;

public class Triangle : Figure
{
    public Triangle(Point XY, double a, double b, double c) : base(XY, () => Math.Sqrt((a + b + c) / 2 * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c)))
    {
        if (a <= 0 && b <= 0 && c <= 0){
            throw new ArgumentOutOfRangeException(a > b ? c > b ? "b" : "c" : "a", $"Длинна стороны треугольника должна превышать 0!");
        }

        if (a + b <= c || b + c <= a || a + c <= b){
            throw new ArgumentException($"Треугольник невозможно построить используя приведенные [{a}, {b}, {c}] длинны сторон");
        }
        
        this.a = a;
        this.b = b;
        this.c = c;
    }

    private double a;
    private double b;
    private double c;
     
    public bool IsRight(){
        if (a > b) (a, b) = (b, a);
        if (b > c) (b, c) = (c, b);
        if (a > c) (a, c) = (c, a);

        return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
    }

    public override double GetArea()
    {
        return Area;
    }
}
