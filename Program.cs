// See https://aka.ms/new-console-template for more information
int  primeironumero, segundonumero, soma;

Console.WriteLine("--- Calculo entre numeros --- ");


Console.WriteLine("digite o primeiro numero:");
primeironumero = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("digite o segundo numero:");
segundonumero = Convert.ToInt32(Console.ReadLine());

soma = primeironumero + segundonumero;

Console.Write($"\nSoma: {soma}");