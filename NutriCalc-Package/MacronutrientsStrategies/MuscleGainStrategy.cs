
using NutriCalc_Package.Interfaces;
using NutriCalc_Package.Models;

namespace NutriCalc_Package.MacronutrientsStrategies
{
    public class MuscleGainStrategy : IMacronutrientsStrategy
    {
        public MacronutrientsModel CalculateMacronutrients(double weight)
        {
            return new MacronutrientsModel
            {
                Carbohydrates = weight * 4.0,
                Proteins = weight * 2.0,
                Fats = weight * 1.0
            };
        }
    }
}