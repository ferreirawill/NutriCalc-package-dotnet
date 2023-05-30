using NutriCalc_Package.Enums;
using NutriCalc_Package.Models;

namespace NutriCalc_Package.Interfaces
{
    public interface IMacronutrients
    {
        MacronutrientsModel CalculateMacronutrients(PhysicalGoalEnum physicalGoal, double weight);
    }
}