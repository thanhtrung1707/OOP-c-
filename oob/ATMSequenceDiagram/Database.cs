using System;
using System.Collections.Generic;

namespace ATMnceDiagram
{
    public class Database
    {
        Dictionary<string, decimal> Accounts;

        public Database()
        {
            Accounts = new Dictionary<string, decimal>();
        }

        public decimal GetBalance(string accountNumber)
        {
            return Accounts[accountNumber];
        }

        public void AddAccount(string accountNumber, decimal balance)
        {
            Accounts[accountNumber] = balance;
        }

        public bool ProcessWithdraw(string accountNumber, decimal amount)
        {
            if (amount > GetBalance(accountNumber))
            {
                Console.WriteLine("Cannot Withdraw ....");
                return false;
            }
            else
            {
                Console.WriteLine($"Withdrawing {amount} from account {accountNumber}");
                Accounts[accountNumber] = Accounts[accountNumber] - amount;
                return true;
            }
        }
        public void Decrease(string accountNumber, decimal amount)
        {
            Accounts[accountNumber] = Accounts[accountNumber] - amount;
        }
    }
}