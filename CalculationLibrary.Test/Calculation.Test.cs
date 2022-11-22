using Xunit;

namespace CalculationLibrary.Test;

public class Calculation_Test
{
    [Theory]
    [InlineData(5,5,10)]
    public void AddShouldReturnedExpectedValue(double x, double y, double expected)
    {

        Calculation calc = new Calculation();

        double actual = calc.Add(x, y);

        Assert.Equal(actual, expected);
    }
    [Theory]
    [InlineData(5,5,0)]
    public void SubstractShouldReturnedExpectedValue(double x, double y, double expected)
    {

        Calculation calc = new Calculation();

        double actual = calc.Substract(x, y);

        Assert.Equal(actual, expected);
    }
    
    [Theory]
    [InlineData(4,2,2)]
    [InlineData(5,2,2.5)]
    public void DivideShouldReturnedExpectedValue(double x, double y, double expected)
    {

        Calculation calc = new Calculation();

        double actual = calc.Divide(x, y);

        Assert.Equal(actual, expected);
    }
    
    [Theory]
    [InlineData(5,2,10)]
    [InlineData(5,1.5,7.5)]
    public void MultiplyShouldReturnedExpectedValue(double x, double y, double expected)
    {

        Calculation calc = new Calculation();

        double actual = calc.Multiply(x, y);

        Assert.Equal(actual, expected);
    }

}