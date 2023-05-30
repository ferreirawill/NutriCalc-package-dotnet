using NutriCalc_Package;


namespace NutriCalc_Tests;

public class IMCTests
{


    [Fact]
    public void CalculateIMCWithValidValues()
    {
        IIMC imc = new IMC();

        Assert.Equal(imc.Calculate(1.75, 80), 26.12);
    }

    [Fact]
    public void ValidatateIMCInvalidValues()
    {
        IIMC imc = new IMC();

        Assert.False(imc.IsValidData(5.1, 830.2));
    }

    [Fact]
    public void ValidatateIMCValidValues()
    {
        IIMC imc = new IMC();

        Assert.True(imc.IsValidData(1.75, 80));
    }

    [Theory]
    [InlineData(17,IMCConstants.UNDERWEIGHT)]
    [InlineData(24, IMCConstants.NORMAL)]
    [InlineData(26, IMCConstants.OVERWEIGHT)]
    [InlineData(30.55, IMCConstants.OBESITY)]
    [InlineData(42, IMCConstants.SEVERE_OBESITY)]
    public void RetornaCategoriaIMC_QuandoIndiceValido_EntaoRetornaDescricao(double imcValue, string expectedResult)
    {
        //Arrange
        IIMC imc = new IMC();

        //Act
        var result = imc.GetClassification(imcValue);

        //Asserts
        Assert.Equal(expectedResult, result);
    }
}