using Projeto33.Service;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto33.Entities
{
    internal class ContaCorrente : Conta, ITributavel
    {
        //calcular tributo 1% da conta

        public ContaCorrente(double valor)
            : base(valor)
        {
        }

        public double CalcularTributos()
        {
            return Valor*0.01;
        }
        
    }
}
