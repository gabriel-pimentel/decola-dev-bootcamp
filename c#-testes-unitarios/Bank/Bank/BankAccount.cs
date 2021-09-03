using System;

namespace BankAccountNS
{
    
    public class BankAccount
    {
        private readonly string customerName;
        private double balance;

        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            this.customerName = customerName;
            this.balance = balance;
        }

        public string CustomerName
        {
            get { return this.customerName; }
        }

        public double Balance
        {
            get { return this.balance; }
        }

        public void Debit(double amount)
        {
            if (amount > this.balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            this.balance -= amount; 
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            this.balance += amount;
        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);

            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }
    }
}
