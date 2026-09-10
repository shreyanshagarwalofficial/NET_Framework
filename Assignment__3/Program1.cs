using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class BankAccount1
    {
        private string accountNumber;
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
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value >= 0)
                    balance = value;
            }
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
                balance = balance + amount;
        }
    }
    internal class Program1
    {
        static void Main2(string[] args)
        {
            BankAccount1 account = new BankAccount1();
            account.AccountNumber = "12584200182";
            account.Balance = 90000000;
            account.Deposit(200000);
            Console.WriteLine("Account No:" + account.AccountNumber);
            Console.WriteLine("Final Bal:" + account.Balance);
        }
    }
}