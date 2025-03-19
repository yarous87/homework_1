using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum AccountType { 
    Personal,
    Organization,
}

namespace homework_1
{
    internal class BankAccount
    {
        private string accountNumber;
        private string owner;
        private double balance;
        private AccountType accountType;

        public BankAccount(string accountNumber, string owner, double balance, AccountType accountType)
        {
            this.accountNumber = accountNumber;
            this.owner = owner;
            this.balance = balance;
            this.accountType = accountType;
        }

        public void deposit(double amount) 
        {
            this.balance += amount;
        }

        public void withdraw(double amount)
        {
            double tmp = this.balance - amount;

            if (tmp < 0) {
                throw new Exception("Insufficient account balance");
            }

            this.balance = tmp;
        }
    }
}
