using System;
using System.Globalization;

namespace Projeto34.Entities
{
    internal class Invoice
    {

        public  double BasicPayment { get; set; }
        public double  Tax { get; set; }

        public Invoice(){

        }
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment { //isso não é um método e sim uma propriedade assim como Tax ou BasicPayment
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return "\nBasic Payment: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal Payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
