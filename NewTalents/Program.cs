// See https://aka.ms/new-console-template for more information
using NewTalents;

Console.WriteLine("Hello, World!");
Calculadora teste = new Calculadora(DateOnly.FromDateTime(DateTime.UtcNow).ToString());
teste.Somar(1, 2);
teste.Subtrair(3, 4);
teste.EhPar(2);

Console.WriteLine(teste.Historico());

foreach (var item in teste.Historico()) Console.WriteLine(item);