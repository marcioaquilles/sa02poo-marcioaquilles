using Sa02.RegradeNegocio;

namespace Sa02Poo.Aplicacao6
{
    internal class Program
    {
        public static void Main()
        {
            Menu();
        }

        public static void PriceFly()
        {
            var valorAviao = new List<double>();

            int qtd, qtdAvioesGeral = 0;
            double valorTotal = 0, valorPorAviao = 0, valor = 0, custoUnitario = 0;
            var e = new String('=', 36);

            while (true)
            {
                {
                    Console.Write("Quantos aviões que cadastrar: ");
                    qtd = int.Parse(Console.ReadLine());
                    valorPorAviao = 0;
                    Aplicativo6RN fly = new();

                    for (int i = 1; i <= qtd; i++)
                    {
                        Console.Write($"Informe o valor do {i}o. Avião: ");
                        valor = double.Parse(Console.ReadLine());

                        valorAviao.Add(valor);
                        fly.ValueByFly(valorPorAviao, valor);
                        fly.TotalValue(valorTotal, valor);                        

                        qtdAvioesGeral++;
                    }

                    Console.WriteLine(e);
                    Console.Write($"Valor de {qtd} Avião(ões) cadastrado(s) R$ {valorPorAviao.ToString("N2")}\n");
                    Console.Write(
                        $"Valor total de {qtdAvioesGeral} Avião(ões) cadastrado(s) R$ {valorTotal.ToString("N2")}\n");
                    custoUnitario = valorTotal / qtdAvioesGeral;
                    Console.Write($"Valor custo unitário R$ {custoUnitario.ToString("N2")}\n");
                    Console.WriteLine(e);
                    valorAviao.Clear();

                    string resp;

                    Console.Write("Deseja cadastrar mais aviões? [sim/nao] ");
                    resp = Console.ReadLine();
                    resp.ToLower();

                    if (resp != "sim")
                    {
                        break;
                    }
                }
            }
        }

        public static void Menu()
        {
            while (true)
            {
                var e = new String('=', 36);
                Console.WriteLine(e);
                string mensagem = "Olá usuário, bem vindo ao programa\n" +
                                  "Utilizando programação funcional" +
                                  "\n" +
                                  "\nDigite uma das opções abaixo:" +
                                  "\n       0 - Sair do programa" +
                                  "\n       1 - Cadastrar Aeronaves";

                Console.Write(mensagem);
                Console.WriteLine();
                Console.Write("Opção: ");

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    Console.WriteLine(e);
                    PriceFly();
                    Console.WriteLine(e);
                }
                else
                {
                    Console.WriteLine("Opção inválida, digite novamente");
                }
            }
        }
    }

}
