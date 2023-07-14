using System.Globalization;
using Exercicio2.Model;

// Exercicio 2: Escreva um programa que faça a leitura do nome, da idade, da altura e e do peso do usuário. Após isso, escreva cada uma das informações em uma linha no console.

Pessoa pessoa = new();

Console.WriteLine("Olá! Queremos te conhecer melhor, insira os dados: ");

Console.WriteLine("Nome: ");
pessoa.Nome = Console.ReadLine();

Console.WriteLine("Idade: ");
pessoa.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Altura: ");
pessoa.Altura = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);


Console.WriteLine("Peso: ");
pessoa.Peso = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);


Console.WriteLine("Dados inseridos: ");
Console.WriteLine($"Nome: {pessoa.Nome}");
Console.WriteLine($"Idade: {pessoa.Idade}");
Console.WriteLine($"Altura: {pessoa.Altura.ToString("F2", CultureInfo.InvariantCulture)}m");
Console.WriteLine($"Peso: {pessoa.Peso.ToString("F2", CultureInfo.InvariantCulture)}Kg");