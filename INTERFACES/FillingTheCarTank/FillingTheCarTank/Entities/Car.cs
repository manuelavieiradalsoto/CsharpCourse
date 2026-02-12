using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillingTheCarTank.Entities
{
    internal class Car: IVehiculo
    {
        public int Fuel { get; set; }

        public Car(int fuel)
        {
            Fuel = fuel;
        }

        public void Drive()
        {
            if (Fuel != 0)
            {
                Console.WriteLine("The Car is driving!");
            }
            else
            {
                Console.WriteLine("We need gasoline");
            }
        }
        public bool Refuel(int amount)
        {
            Fuel += amount;
            return true;

        }
    }
}
