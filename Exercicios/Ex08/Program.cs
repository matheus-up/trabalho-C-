
using System.Globalization;

Console.Write("Informe seu peso (kg): ");
double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Informe sua altura (m): ");
double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double imc = peso / (altura * altura);

Console.WriteLine($"\nSeu IMC é: {imc:F2}");

string classificacao;

if (imc < 18.5)
{
    classificacao = "Abaixo do peso";
}
else if (imc < 25.0)
{
    classificacao = "Peso normal";
}
else if (imc < 30.0)
{
    classificacao = "Sobrepeso";
}
else
{
    classificacao = "Obesidade";
}

Console.WriteLine($"Classificação: {classificacao}");
