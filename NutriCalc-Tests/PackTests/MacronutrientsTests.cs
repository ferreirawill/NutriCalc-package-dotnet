using NutriCalc_Package;
using NutriCalc_Package.Enums;
using NutriCalc_Package.Interfaces;
using NutriCalc_Package.MacronutrientsStrategies;
using NutriCalc_Package.Models;

namespace NutriCalc_Tests.PackTests
{
    public class MacronutrientsTests
    {
        [Theory]
        [InlineData(PhysicalGoalEnum.MuscleGain, 93.5, 374.0, 187.0, 93.5)]
        [InlineData(PhysicalGoalEnum.WeightMaintenance, 93.5, 374.0, 374.0, 187.0)]
        [InlineData(PhysicalGoalEnum.WeightLoss, 93.5, 280.5, 374, 280.5)]

        public void CalculateMacronutrientsWithValidValues(PhysicalGoalEnum physicalGoal, double weight, double carbs, double proteins, double fats)
        {
            IMacronutrients macronutrients = new Macronutrients();

            MacronutrientsModel expectedResult = new MacronutrientsModel()
            {
                Carbohydrates = carbs,
                Proteins = proteins,
                Fats = fats
            };



            MacronutrientsModel result = macronutrients.CalculateMacronutrients(physicalGoal, weight);

            Assert.Equal(carbs, result.Carbohydrates);
            Assert.Equal(proteins, result.Proteins);
            Assert.Equal(fats, result.Fats);
        }


        [Theory]
        [InlineData(PhysicalGoalEnum.MuscleGain, 93.5, 374.0, 187.0, 93.5)]
        [InlineData(PhysicalGoalEnum.WeightMaintenance, 93.5, 374.0, 374.0, 187.0)]
        [InlineData(PhysicalGoalEnum.WeightLoss, 93.5, 280.5, 374, 280.5)]
        public void CalculateMacronutrientsWithValidValuesUsingStrategy(PhysicalGoalEnum physicalGoal, double weight, double carbs, double proteins, double fats)
        {
            MacronutrientsContext strategy = new();

            switch (physicalGoal)
            {
                case PhysicalGoalEnum.MuscleGain:
                    strategy.SetStrategy(new MuscleGainStrategy());
                    break;
                case PhysicalGoalEnum.WeightMaintenance:
                    strategy.SetStrategy(new WeightMaintenanceStrategy());
                    break;
                case PhysicalGoalEnum.WeightLoss:
                    strategy.SetStrategy(new WeightLossStrategy());
                    break;
            }

            MacronutrientsModel expectedResult = new MacronutrientsModel()
            {
                Carbohydrates = carbs,
                Proteins = proteins,
                Fats = fats
            };

            MacronutrientsModel result = strategy.ExecuteStrategy(weight);

            Assert.Equal(carbs, result.Carbohydrates);
            Assert.Equal(proteins, result.Proteins);
            Assert.Equal(fats, result.Fats);
        }
    }
}