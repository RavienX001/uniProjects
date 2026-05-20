using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountManager
{
    internal class BankAccount
    {
        private int balance;
        private int accountNumber;

        public BankAccount(int balance, int accountNumber)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public void Diposit(int amount)
        {
            balance = balance + amount;
        }

        public void Withdraw(int amount)
        {
            if (balance > 0 && balance > amount) {
                balance = balance - amount; }
        }

        public void setAccountNumber(int accountNumber) { this.accountNumber = accountNumber; }
    }
}
