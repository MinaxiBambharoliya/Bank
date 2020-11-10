using System;
using System.Collections.Generic;
using System.Text;

namespace BankPoco
{
    interface ITransaction
    {
        public void Deposite(decimal amount);

        public decimal Withdrawals(decimal amount);

        public decimal CheckBalance();

    }
}
