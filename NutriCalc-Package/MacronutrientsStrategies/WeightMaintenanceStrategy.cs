using NutriCalc_Package.Interfaces;
using NutriCalc_Package.Models;

namespace NutriCalc_Package.MacronutrientsStrategies
{
    public class WeightMaintenanceStrategy : IMacronutrientsStrategy
    {
        public MacronutrientsModel CalculateMacronutrients(double weight)
        {
            return new MacronutrientsModel
            {
                Carbohydrates = weight * 4.0,
                Proteins = weight * 4.0,
                Fats = weight * 2.0
            };
        }
    }
}