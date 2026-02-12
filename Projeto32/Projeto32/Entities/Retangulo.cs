using Projeto32.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto32.Entities
{
    internal class Retangulo : AreaCalculavel
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Retangulo(double basee, double altura) 
        {
            Base = basee;
            Altura = altura;
        }


        public double CalcularArea()
        {
            return Base*Altura;
        }
    }
}
