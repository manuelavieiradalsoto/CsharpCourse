using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto33.Service
{
    internal class SeguroDeVida : ITributavel
    {
        //quanto é taxa = 42 reais (fixo)
        public double CalcularTributos()
        {
            return 42.00;
        }
    }
}
