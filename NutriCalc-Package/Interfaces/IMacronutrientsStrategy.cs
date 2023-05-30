using NutriCalc_Package.Models;

namespace NutriCalc_Package.Interfaces
{
    public interface IMacronutrientsStrategy
    {
        MacronutrientsModel CalculateMacronutrients(double weight);
    }
}