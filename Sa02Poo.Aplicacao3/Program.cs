// vai multiplicar a quantidade de assentos pela quantidade de aviões, considere
// que cada avião possui 17 assentos

using Sa02.RegradeNegocio;

int quantidaDeAvioes, quantidaDeAssentos;

Console.Write("Informe a quantidade de aviões: ");
quantidaDeAvioes = Convert.ToInt32(Console.ReadLine());

Aplicativo3RN fly = new();

quantidaDeAssentos = fly.CalculateTotalSeats(quantidaDeAvioes);

Console.WriteLine();
var e = new String('=', 36);
Console.WriteLine(e);
Console.Write($" Quantidade total de assentos: {quantidaDeAssentos}\n");
Console.WriteLine(e);
Console.ReadLine();