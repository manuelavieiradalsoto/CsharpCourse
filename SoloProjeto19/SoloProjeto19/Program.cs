using SoloProjeto19.Entities.Enum;
using System;
using SoloProjeto19.Entities;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string nameDept = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level(Junior/MidLevel/Senior):  ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());//convertendo string p/enum
            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine());

            Department dept = new Department();
            Worker worker = new Worker(name, level, salary, dept);

            Console.Write("How many contracts to this worker? ");
            int employee = int.Parse(Console.ReadLine());

            for (int i = 0; i <employee; i++)
            {
                Console.Write($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour:  ");
                double value = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contracts = new HourContract(date, value, hours);
                worker.AddContract(contracts);
            }


            Console.Write("Enter month and year to calculate income (MM/YYYY):  ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: "+ worker.Name);
            Console.WriteLine("Department: "+ worker.Department.Name);
            Console.WriteLine("Income for " +monthAndYear+": "+ worker.Income(year, month));
        }
    }
}