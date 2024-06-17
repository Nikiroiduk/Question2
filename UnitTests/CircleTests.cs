using Question2;

namespace UnitTests;

public class CircleTests
{
    [Fact]
    public void Area_Ris1_ReturnTrue()
    {
        Circle c = new(new System.Drawing.Point(0, 0), 1); 
        var result = c.GetArea();
        Assert.True(result == Math.PI);
    }

    [Fact]
    public void Ctor_RisLessThen0_ReturnTrue(){
        var result = Record.Exception(() => 
            {
                Circle c = new(new System.Drawing.Point(0, 0), -1);
            }
        );

        Assert.NotNull(result);
        Assert.IsType<ArgumentOutOfRangeException>(result);
        Assert.Equal("Радиус должен быть больше 0! (Parameter 'r')", result.Message);
    }
}