
using Projeto22.Entities;
using System;

namespace Projeto22
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(bacc.Balance);

            //UPCASTING

            Account acc1 = bacc;

            Account acc2 = new BusinessAccount(1003, "BOB", 0.0, 200.0);

            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING

            BusinessAccount acc4 = acc2 as BusinessAccount;
            acc4.Loan(100);




        }
    }
}