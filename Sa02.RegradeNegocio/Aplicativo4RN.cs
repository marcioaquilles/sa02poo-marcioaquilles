using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02.RegradeNegocio
{
    public class Aplicativo4RN
    {       
        public decimal DivideValue(decimal value = 5000, decimal clients = 10)
        {
            return value / clients;
        }
    }
}
