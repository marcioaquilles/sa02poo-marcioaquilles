// Calcular a soma total de cinco peças no estoque da oficina de aeronaves.

using Sa02.RegradeNegocio;

double somaTotal;

Console.WriteLine("Soma Total de 5 Peças em estoque\n");

Aplicativo7RN fly = new Aplicativo7RN();
somaTotal = fly.TotalSumOfPieces();
somaTotal.ToString("N2");

Console.WriteLine();
var e = new String('=', 42);
Console.WriteLine(e);
Console.Write($" Valor Total das Peças R$ {somaTotal} Reais\n");
Console.WriteLine(e);
Console.ReadLine();