using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02.RegradeNegocio
{
    
    /*!Metodo para Calcular o total de assentos de um determinado número de aviões, TotalSeats
    por padrão leva o valor de 17.*/
    
    
    public class Aplicativo3RN
    {
        public int CalculateTotalSeats(int totalFlys, int TotalSeats = 17)
        {
            return totalFlys * TotalSeats;
        }
    }
}
