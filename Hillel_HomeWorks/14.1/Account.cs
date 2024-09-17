using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._1
{
    class Account
    {
        private string name;
        private double sum;

        public Account(string name, double balance)
        {
            this.name = name;
            if (balance >= 0)
            {
                this.sum = balance;
            }
            else
            {
                //this.sum = 0;
                Console.WriteLine("Balance cannot be negative");
            }
        }

        public void PutMoney(double amount)
        {
            if (amount > 0)
            {
                sum += amount;
                Console.WriteLine($"Added {amount}$");
            }
            else
            {
                Console.WriteLine("Amount must be positive");
            }
        }

        public void WithdrawMoney(double amount)
        {
            if (amount > 0 && amount <= sum)
            {
                sum -= amount;
                Console.WriteLine($"Withdrew {amount}$");
            }
            else if (amount > sum)
            {
                Console.WriteLine("Not enough balance for the withdrawal");
            }
            else
            {
                Console.WriteLine("Amount must be positive");
            }
        }
        public double Balance
        { 
            get { return sum; } 
        }
    }
}
