using System.Drawing;
using Question2;

namespace UnitTests;

public class TriangleTests
{
    [Fact]
    public void Area_abcIs1_ReturnTrue()
    {
        Triangle t = new(new System.Drawing.Point(0, 0), 1, 1, 1); 
        var area = Math.Sqrt(1.5 * Math.Pow(.5, 3));

        var result = t.GetArea();

        Assert.True(result == area);
    }

    [Fact]
    public void Ctor_abcIsLessThen0_HandleException(){
        var result = Record.Exception(() => 
            {
                Triangle t = new(new System.Drawing.Point(0, 0), -1, -2, -3);
            }
        );

        Assert.NotNull(result);
        Assert.IsType<ArgumentOutOfRangeException>(result);
        Assert.Equal("Длинна стороны треугольника должна превышать 0! (Parameter 'c')", result.Message);
    }

    [Fact]
    public void Ctor_abcIsIncorrect_HandleException(){
        var result = Record.Exception(() => 
            {
                Triangle t = new(new System.Drawing.Point(0, 0), 1, 2, 3);
            }
        );

        Assert.NotNull(result);
        Assert.IsType<ArgumentException>(result);
        Assert.Equal("Треугольник невозможно построить используя приведенные [1, 2, 3] длинны сторон", result.Message);
    }

    [Fact]
    public void IsRight_abcIs345_ReturnTrue(){
        Triangle t = new(new Point(0, 0), 3, 4, 5);
        bool result = t.IsRight();
        Assert.True(result == true);
    }
}