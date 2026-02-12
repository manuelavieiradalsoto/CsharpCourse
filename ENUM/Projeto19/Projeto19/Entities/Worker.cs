using System;
using Projeto19.Entities.Enum;
using System.Collections.Generic;

namespace Projeto19.Entities
{
    internal class Worker
    {

        public string Name { get; set; }
        public WorkLevel  Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contract { get; private set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkLevel level, double salary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = salary;
            Department = department;
        }


        public void AddContract(HourContract contract)
        {
            //metodo para adicionar contrato na lista de contratos
            Contract.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            //metodo para remover contrato na lista de contratos

            Contract.Remove(contract);
        }

        public double Income( int year, int month)
        {
            double sum = BaseSalary;
            //começamos com basesalary pq o valor de 1.200 já vem por padrão para o trabalhador.

            foreach (HourContract contract in Contract)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }

            }
            return sum;
           
        }
    }
}
