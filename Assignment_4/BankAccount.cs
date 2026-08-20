using System;

namespace Assignment_3
{
    internal class BankAccount
    {
        long accountNo;
        string holderName;
        double balance;
        public BankAccount(long accountNo, string holderName, double balance = 1000)
        {
            this.accountNo = accountNo;
            this.holderName = holderName;
            this.balance = balance;
        }
        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine("Deposit Successful. New Balance: " + balance);
        }

        public void Withdrawal(int amount)
        {
            if (balance < amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Withdrawal Successful. New Balance: " + balance);
            }
        }
        public void Display()
        {
            Console.WriteLine("Account No: " + accountNo);
            Console.WriteLine("Holder Name: " + holderName);
            Console.WriteLine("Balance: " + balance);
        }

        static void Main13(string[] args)
        {
            BankAccount acc = new BankAccount(7906448267, "Surya", 2000);

            acc.Display();
            acc.Deposit(500);
            acc.Withdrawal(700);
            acc.Display();

            Console.ReadLine();
        }
    }
}
