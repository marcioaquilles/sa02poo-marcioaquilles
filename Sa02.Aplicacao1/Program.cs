using Sa02Poo.RegradeNegocio;

namespace Sa02Poo.Aplicacao1
{
    internal class Program
    {
        public static void Main()
        {
            decimal valorAviao1, valorAviao2, valorTotal;

            Console.Write("Informe o valor do Primeiro Avião: ");
            valorAviao1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Informe o valor do Segundo Avião: ");
            valorAviao2 = Convert.ToDecimal(Console.ReadLine());

            Aplicativo1RN fly = new();

            valorTotal = fly.SomarDoisAvioes(valorAviao1, valorAviao2);
            valorTotal.ToString("N2");
           
            Console.WriteLine();
            var e = new String('=', 36);
            Console.WriteLine(e);
            Console.Write($" Valor dos Aviões R$ {valorTotal} Reais\n");
            Console.WriteLine(e);
            Console.ReadLine();
        }
    }
}