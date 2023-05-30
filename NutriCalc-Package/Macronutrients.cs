using NutriCalc_Package.Enums;
using NutriCalc_Package.Interfaces;
using NutriCalc_Package.Models;

namespace NutriCalc_Package
{
    public class Macronutrients : IMacronutrients
    {
        public MacronutrientsModel CalculateMacronutrients(PhysicalGoalEnum physicalGoal, double weight)
        {
            if (physicalGoal == PhysicalGoalEnum.WeightLoss)
            {
                return new MacronutrientsModel
                {
                    Carbohydrates = weight * 3.0,
                    Proteins = weight * 4.0,
                    Fats = weight * 3.0
                };

            }
            else if (physicalGoal == PhysicalGoalEnum.WeightMaintenance)
            {
                return new MacronutrientsModel
                {
                    Carbohydrates = weight * 4.0,
                    Proteins = weight * 4.0,
                    Fats = weight * 2.0
                };
            }
            else
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
}