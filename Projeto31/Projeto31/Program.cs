using System.Globalization;
using Projeto31.Entities;
using Projeto31.Services;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler os dados de um contrato (número do contrato,data do contrato,
            //e valor total do contrato).

            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(number, date, value);

            Console.Write("Enter number of installments: ");
            int month = int.Parse(Console.ReadLine());

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, month);

            
            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
            

        }
    }
}