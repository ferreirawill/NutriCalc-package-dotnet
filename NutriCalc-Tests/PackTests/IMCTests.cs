using NutriCalc_Package;


namespace NutriCalc_Tests;

public class IMCTests
{
    [Fact]
    public void CalculateIMCWithValidValues()
    {
        IIMC imc = new IMC();
        
        Assert.Equal(imc.Calculate(1.75, 80),26.12);
    }
}