using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto29.Services
{
    internal class BrazilTaxService : ITaxService
        //"BrazilTaxService é um sub tipo de ITaxService"
    {
        public double Tax (double amount) {
            if (amount <= 100.0)
            {
                return amount * 0.2; 
            }
            else { return amount * 0.15; }
        }
    }
}
