//! Calcular a média total do faturamento trimestral da VoeAirlines.

using Sa02.RegradeNegocio;
using System;

double mes1, mes2, mes3, mediaTotal;

Console.Write("Informe o faturamento do mês 1 R$: ");
mes1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Informe o faturamento do mês 2 R$: ");
mes2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Informe o faturamento do mês 3 R$: ");
mes3 = Convert.ToDouble(Console.ReadLine());

Aplicativo5RN fly = new();
mediaTotal = fly.AverageTotalBilling(mes1, mes2, mes3);
mediaTotal.ToString("N2");

Console.WriteLine();
Console.BackgroundColor = ConsoleColor.Blue;
var e = new String('=', 36);
Console.WriteLine(e);
Console.Write($" Média do Faturamento R$ {mediaTotal} Reais\n");
Console.WriteLine(e);
Console.ReadLine();