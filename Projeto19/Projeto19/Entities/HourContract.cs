using System;
namespace Projeto19.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double valuePerHour { get; set; }
        public int Hours { get; set; }

        //construtor padrao
        public HourContract()
        {
        }
        //construtor com argumentos
        public HourContract(DateTime date, double perhour, int hours)
        {
            Date = date;
            valuePerHour = perhour;
            Hours = hours;
        }

        //metodo para rertornar valor total do contrato.
        public double TotalValue()
        {
            return Hours * valuePerHour;
        }



    }
}
