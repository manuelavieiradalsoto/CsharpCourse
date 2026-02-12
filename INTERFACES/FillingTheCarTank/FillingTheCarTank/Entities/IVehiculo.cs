using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingTheCarTank.Entities
{
    interface IVehiculo
    {
        void Drive();
        bool Refuel(int amount);

    }
}
