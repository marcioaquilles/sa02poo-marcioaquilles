// Dividir 5000 (cinco mil reais) para 10 clientes especiais da VoeAirlines.

using Sa02.RegradeNegocio;

decimal valor;

Aplicativo4RN fly = new();

valor = fly.DivideValue();
valor.ToString("N2");

Console.WriteLine();
var e = new String('=', 50);
Console.WriteLine(e);
Console.Write($" Valor dividido para cada cliente R$ {valor} Reais\n");
Console.WriteLine(e);
Console.ReadLine();