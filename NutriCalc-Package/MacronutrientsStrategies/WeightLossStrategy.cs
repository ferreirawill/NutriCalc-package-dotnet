using NutriCalc_Package.Interfaces;
using NutriCalc_Package.Models;

namespace NutriCalc_Package.MacronutrientsStrategies
{
    public class WeightLossStrategy : IMacronutrientsStrategy
    {
        public MacronutrientsModel CalculateMacronutrients(double weight)
        {
            return new MacronutrientsModel
            {
                Carbohydrates = weight * 3.0,
                Proteins = weight * 4.0,
                Fats = weight * 3.0
            };
        }
    }
}