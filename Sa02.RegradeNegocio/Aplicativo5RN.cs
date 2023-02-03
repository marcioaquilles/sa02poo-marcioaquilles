using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02.RegradeNegocio
{
    public class Aplicativo5RN
    {
        //! Método calcula a média do faturamento de 3 meses.

        public double AverageTotalBilling(double month1, double month2, double month3)
        {
            double mediaTotal = (month1 + month2 + month3) / 3;

            return mediaTotal;
        }
    }
}
