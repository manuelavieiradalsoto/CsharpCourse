using System;
using Projeto34.Services;

namespace Projeto34.Services
{
    internal class BrazilTaxService: ITaxService
    {
        private double _taxLow = 0.15;
        private double _taxHigh = 0.2;
        public double Tax( double amount)
        {
            if (amount <= 100.00)
            {
                return amount * _taxLow;
            }
            else
            {
                return amount * _taxHigh;
            }
            
        }
    }
}
