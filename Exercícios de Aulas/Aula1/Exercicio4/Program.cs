
using System.Globalization;

// Exercício 4: Escreva um programa para calcular a área de um círculo.O valor do raio r será digitado pelo usuário (assumir que serão digitados apenas valores positivos)

Console.WriteLine("Calcular a área de um círculo!");
Console.WriteLine("Insira o valor do raio do círculo: ");

double raio = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);


double areaCirculo = CalcularRaioCirculo(raio);
Console.WriteLine($"A área do círculo é {areaCirculo.ToString("F4", CultureInfo.InvariantCulture)}!");



static double CalcularRaioCirculo(double raio)
{
    return Math.PI * Math.Pow(raio, 2);
}
