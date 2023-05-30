using NutriCalc_Package.Interfaces;
using NutriCalc_Package.Models;

namespace NutriCalc_Package
{
    public class MacronutrientsContext
    {
        private IMacronutrientsStrategy? _macronutrientsStrategy;

        public void SetStrategy(IMacronutrientsStrategy macronutrientsStrategy) => _macronutrientsStrategy = macronutrientsStrategy;

        public MacronutrientsModel ExecuteStrategy(double weight) => _macronutrientsStrategy!.CalculateMacronutrients(weight);
    }
}