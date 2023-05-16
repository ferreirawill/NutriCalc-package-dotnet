using NutriCalc_Package;

var imc = new IMC();
var imcValue = imc.Calculate(1.75, 80);

Console.WriteLine($"Valor do IMC: {imcValue} | Classificação: {imc.GetClassification(imcValue)}");
