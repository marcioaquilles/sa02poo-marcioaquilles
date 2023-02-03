using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02.RegradeNegocio
{
    public class Aplicativo7RN
    {
        //! Metodo para calcular a soma de 5 peças em estoque

        public double TotalSumOfPieces(int qtdPieces = 5)
        {
            double[] precoPeca = new double[qtdPieces];
            double somaTotal = 0;

            for (int i = 0; i < precoPeca.Length; i++)
            {
                Console.Write($"Informe o valor da {i + 1}o. Peça R$: ");
                precoPeca[i] = Convert.ToDouble(Console.ReadLine());
                somaTotal += precoPeca[i];
            }

            return somaTotal;
        }
    }
}
