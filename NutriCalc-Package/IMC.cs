namespace NutriCalc_Package;
public class IMC :IIMC
{
    public double Calculate(double height, double weight)
    {
        if (!IsValidData(height, weight))
        {
            throw new Exception("Não foi possível calcular o IMC! Peso e altura inválidos");
        }
        return Math.Round(weight / (height * height), 2);
    }

    public string GetClassification(double imc)
    {
        if (imc < 18.5)
        {
            return IMCConstants.UNDERWEIGHT;
        }
        else if (imc >= 18.5 && imc < 25)
        {
            return IMCConstants.NORMAL;
        }
        else if (imc >= 25 && imc < 30)
        {
            return IMCConstants.OVERWEIGHT;
        }
        else if (imc >= 30 && imc < 40)
        {
            return IMCConstants.OBESITY;
        }
        else
        {
            return IMCConstants.SEVERE_OBESITY;
        }
    }

    public bool IsValidData(double height, double weight)
    {
        return (height < 3.0 && weight <= 300) || (height <= 0 && weight <= 0);
    }
}
