using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto33.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        //construtor que passa a mensage para o base exception

        public DomainException(string message) 
            : base(message)
        {
        }
    }
}
