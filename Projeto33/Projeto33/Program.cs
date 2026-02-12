using Projeto33.Entities;
using Projeto33.Entities.Exceptions;
using System;
using System.Globalization;
using System.Security.Principal;
using Projeto33.Entities;
using Projeto33.Service;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Manu´s Bank!\nHow can i help you?");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            Console.WriteLine();
            

            Console.Write("Initial value: ");
            double initalValue = double.Parse(Console.ReadLine());
            ContaPoupanca contaPoupanca = new ContaPoupanca(initalValue);
            ContaCorrente contaCorrente = new ContaCorrente(initalValue);
            SeguroDeVida seguro = new SeguroDeVida();

            int op = 0;
            Console.Write("  Deposit in:\n1- Current Account;\n2- Savings Account;\n\nWithdraw in:\n3- Current Account;\n4- Savings Account;\n5- Check My Account´s Information;\n6- Quit.\n\n");
            while (op != 6) {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Select option:__");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Console.Write("Deposit amount: ");
                    double valorDepositCorrente = double.Parse(Console.ReadLine());
                    contaCorrente.Depositar(valorDepositCorrente);
                    Console.WriteLine("Tribute: " + contaCorrente.CalcularTributos().ToString("F2", CultureInfo.InvariantCulture));
                    Console.Write("Value Account: " + contaCorrente.Valor);

                }
                if (op == 2)
                {
                    Console.Write("Deposit amount: ");
                    double valorDepositPoupanca = double.Parse(Console.ReadLine());
                    Console.WriteLine("Value Account: " + contaPoupanca.Depositar(valorDepositPoupanca).ToString("F2", CultureInfo.InvariantCulture));
                    
                }
                if (op == 3)
                {
                    Console.Write("Withdraw amount: ");
                    double valorWithdrawCorrente = double.Parse(Console.ReadLine());
                    contaCorrente.Sacar(valorWithdrawCorrente);
                    Console.WriteLine("Tribute: " + contaCorrente.CalcularTributos().ToString("F2", CultureInfo.InvariantCulture));
                    Console.Write("Value Account: " + contaCorrente.Valor);
                }
                if (op == 4)
                {
                    Console.Write("Withdraw amount: ");
                    double valorWithDrawPoupanca = double.Parse(Console.ReadLine());
                    Console.WriteLine("Value Account: " + contaPoupanca.Sacar(valorWithDrawPoupanca).ToString("F2", CultureInfo.InvariantCulture));
                    
                }
                if (op == 5)
                {
                    Console.WriteLine("Account Information:");
                    Console.WriteLine("Savings Account:\nValue Account: "+ contaPoupanca.Valor);
                    Console.WriteLine();
                    Console.WriteLine("Current Account:\nValue Account: " + contaCorrente.Valor);
                    Console.WriteLine();
                    double totalTribute = contaCorrente.CalcularTributos() + seguro.CalcularTributos();
                    Console.WriteLine("Total Tributes: "+ totalTribute);
                }
            }
        }
    }
}