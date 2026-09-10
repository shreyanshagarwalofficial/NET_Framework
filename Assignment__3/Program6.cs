using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class ControlledBankAccount
    {
        private string accountNumber;
        private string accountHolder;
        private double balance;

        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }

        public string AccountHolder
        {
            get
            {
                return accountHolder;
            }
            set
            {
                accountHolder = value;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
                Console.WriteLine("Deposit successful.");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Withdrawal amount must not exceed the balance.");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
            else
            {
                balance = balance - amount;
                Console.WriteLine("Withdrawal successful.");
            }
        }
    }

    internal class Program6
    {
        static void Main(string[] args)
        {
            ControlledBankAccount a = new ControlledBankAccount();
            a.AccountNumber = "12584200182";
            a.AccountHolder = "Shreyansh";
            a.Deposit(10000);
            a.Withdraw(3000);
            Console.WriteLine("Account Number" + a.AccountNumber);
            Console.WriteLine("Account Holder " + a.AccountHolder);
            Console.WriteLine("Updated Balance" + a.Balance);
        }
    }
}