//Group Programming Exercise:
//You are a programmer at a large bank and you need to implement a deposit system for
//several different types of accounts (savings, checking and line of credit).
//Your system must allow withdrawals, deposits and balance checks on the accounts in a
//generic way. The chequing account will have overdraft protecting of $500. All accounts will
//have an eight character accountCode that must be set by the constructor and cannot be
//changed. New accounts always have a starting balance of 0, except a line of credit – which
//is created with the amount of available credit.
//Use inheritance and create a base class (class, abstract class or interface or all three) that
//the account sub-types inherit functionality from.
//Create the concrete classes for each account type.




using System;
using System.Collections.Generic;
using System.Text;

namespace BankPoco
{
   public class AccountPoco
    {
        public readonly string AccountNo;
        protected decimal Balance { get; set; }

        public AccountPoco(string accountNo)
        {
            AccountNo = accountNo;
        }

    }

    public class SavingAccount : AccountPoco, ITransaction
    {

        public SavingAccount(string accountNo) : base (accountNo)
        {
            Balance = 0;
        }

        public decimal CheckBalance()
        {
            return Balance;
        }

        public void Deposite(decimal amount)
        {
            Balance += amount;
        }

        public decimal Withdrawals(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine($"Low Balance\n Your current balance is : {Balance}");
            }
            else
            {
                Balance -= amount;
            }
            return Balance;
        }
    }

    public class CheckingAccount : AccountPoco, ITransaction
    {

        public CheckingAccount(string accountNo) : base(accountNo)
        {
            Balance = 500;
        }

        public decimal CheckBalance()
        {
            return Balance;
        }

        public void Deposite(decimal amount)
        {
            Balance += amount;
        }

        public decimal Withdrawals(decimal amount)
        {
            if (amount > (Balance-500))
            {
                Console.WriteLine($"Low Balance\n Your current balance is : {Balance}");
            }
            else
            {
                Balance -= amount;
            }
            return Balance;
        }
    }

    public class LineOfCreditAccount : AccountPoco, ITransaction
    {

        public LineOfCreditAccount(string accountNo, decimal balance) : base(accountNo)
        {
            Balance = balance;
        }

        public decimal CheckBalance()
        {
            throw new NotImplementedException();
        }

        public void Deposite(decimal amount)
        {
            throw new NotImplementedException();
        }

        public decimal Withdrawals(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
