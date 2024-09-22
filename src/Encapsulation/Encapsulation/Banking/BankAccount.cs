using System;

namespace Encapsulation.Banking
{
    public class BankAccount
    {
        private string _accountNumber = "Unknown";
        private string _accountHolder = "Unknown";
        private double _balance;

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public string AccountHolder
        {
            get { return _accountHolder; }
            set { _accountHolder = value; }
        }

        public double Balance
        {
            get { return _balance; }
            private set
            {
                if (value < 0)
                    _balance = 0.0;
                else
                    _balance = value;
            }
        }

        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            AccountNumber = string.IsNullOrWhiteSpace(accountNumber) ? "Unknown" : accountNumber;
            AccountHolder = string.IsNullOrWhiteSpace(accountHolder) ? "Unknown" : accountHolder;

            Balance = balance < 0 ? 0.0 : balance;
        }

        public void Deposit(double amount)
        {
            if (amount >= 0)
            {
                Balance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (amount >= 0 && Balance - amount >= 0)
            {
                Balance -= amount;
            }
        }

        public double GetBalance()
        {
            return Balance;
        }
    }
}
