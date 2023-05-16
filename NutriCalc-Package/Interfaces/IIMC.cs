namespace NutriCalc_Package
{
    public interface IIMC
    {
        double Calculate(double height, double weight);
        string GetClassification(double imc);
        bool IsValidData(double height, double weight);

    }
}