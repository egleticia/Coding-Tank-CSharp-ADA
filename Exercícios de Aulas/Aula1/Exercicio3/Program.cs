
// Exercício 3: Escreva um programa que faça a leitura de uma frase, que pode ser uma citação, um ditado 
//ou um excerto de um texto. Ao final, escreva a frase digitada e, em uma nova linha, o número 
// de caracteres desta frase.

Console.WriteLine("Insira uma frase: ");
string frase = Console.ReadLine();

Console.WriteLine($"Frase inserida: {frase}");
Console.WriteLine($"A frase contém {frase.Length} caracteres.");