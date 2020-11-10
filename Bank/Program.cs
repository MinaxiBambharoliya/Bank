using BankPoco;
using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount saving = new SavingAccount("12345678");
            Console.WriteLine($"Account Number : {saving.AccountNo}");
            Console.WriteLine($"Current Saving Balance : {saving.CheckBalance()}");

            saving.Deposite(300M);
            Console.WriteLine($"Current Saving Balance : {saving.CheckBalance()}");

            saving.Withdrawals(200M);
            Console.WriteLine($"Current Saving Balance : {saving.CheckBalance()}");



        }
    }
}
