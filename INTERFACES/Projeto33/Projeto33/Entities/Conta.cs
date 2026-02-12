using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto33.Entities.Exceptions;

namespace Projeto33.Entities
{
    internal class Conta
    {
        public double Valor { get; set; }

        public Conta(double valor)
        {
            Valor = valor;
        }


        public double Sacar(double amount)
        {
            if (Valor < 0 && Valor < amount)
            {
                throw new DomainException("Erro: **Saldo Insuficiente");
            }
            else
            {
                return Valor -= amount;
            }

        }

        public double Depositar(double amount)
        {
            if (Valor < 0)
            {
                throw new DomainException("Erro: **Impossível depositar numeros negativos");
            }
            else
            {
                return Valor += amount;
            }
        }

        public double ObterSaldo()
        {
            return Valor;
        }

        public override string ToString()
        {
            return "Saldo final: "
                + ObterSaldo().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
