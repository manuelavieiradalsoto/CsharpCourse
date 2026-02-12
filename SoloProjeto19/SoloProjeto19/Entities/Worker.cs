using SoloProjeto19.Entities.Enum;
using System;
using System.Collections.Generic;
using SoloProjeto19.Entities;

namespace SoloProjeto19.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();
        

        public Worker()
        {

        }


        public Worker(string name, WorkerLevel level, double salary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = salary;
            Department = department;
        }


        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }   
            }
            return sum;
        }


    }
}
