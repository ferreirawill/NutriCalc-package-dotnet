using NutriCalc_Package;
using NutriCalc_Package.MacronutrientsStrategies;
using NutriCalc_Package.Models;


Console.WriteLine("\t\tBem vindo ao NutriCalc! \n" +
    "Digite o seu peso: (Utilize virgula para separar os decimais)");
var weight = Console.ReadLine();
double weightInt = double.TryParse(weight, out weightInt) ? weightInt : throw new Exception("Peso inválido! Digite um número positivo.");

Console.WriteLine("Digite a sua altura: (Utilize virgula para separar os decimais)");
var height = Console.ReadLine();
double heightInt = double.TryParse(height, out heightInt) ? heightInt : throw new Exception("Altura inválida! Digite um número positivo.");

Console.WriteLine("Digite o número do seu objetivo físico: \n" +
    "0 - Ganho de massa muscular \n" +
    "1 - Perda de peso \n" +
    "2 - Manutenção de peso");
var physicalGoal = Console.ReadLine();

int physicalGoalInt = int.TryParse(physicalGoal, out physicalGoalInt) ? physicalGoalInt : throw new Exception("Objetivo físico inválido! Digite um número entre 0 e 2.");

if (physicalGoalInt < 0 || physicalGoalInt > 2)
{
    throw new Exception("Objetivo físico inválido! Digite um número entre 0 e 2.");
}

var imc = new IMC();
var imcValue = imc.Calculate(heightInt, weightInt);

Console.WriteLine($"{heightInt} | {weightInt} Valor do IMC: {imcValue} | Classificação: {imc.GetClassification(imcValue)}");

MacronutrientsContext strategy = new();

switch (physicalGoalInt)
{
    case 0:
        strategy.SetStrategy(new MuscleGainStrategy());
        break;
    case 1:
        strategy.SetStrategy(new WeightLossStrategy());
        break;
    case 2:
        strategy.SetStrategy(new WeightMaintenanceStrategy());
        break;
}

MacronutrientsModel result = strategy.ExecuteStrategy(weightInt);

Console.WriteLine($"Para atingir o objetivo físico, consuma: \n" +
    $"* {result.Carbohydrates}g de Carboidratos\n" +
    $"* {result.Proteins}g de Proteinas\n" +
    $"* {result.Fats}g de Gorduras");