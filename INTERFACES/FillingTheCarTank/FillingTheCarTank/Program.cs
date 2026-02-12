using System;
using FillingTheCarTank.Entities;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fuel = int.Parse(Console.ReadLine());   
            Car car = new Car(fuel);

            car.Drive();
        }
    }
}