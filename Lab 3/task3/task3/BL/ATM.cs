using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class ATM
    {
        public double balance;
        public List<string> transactions = new List<string>();

        public ATM() 
        {
            balance = 100;
        }

        public void Deposit(double amount)
        {
            balance += amount;
            Add_History("You have deposit the amount of "+ amount +". Your balance is: "+  balance);
        }

        public double CheckBalance()
        {
            return balance;
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal Completed Successfully. Your remaining balance: {balance}");
                Add_History("You have withdrawn the amount of: " + amount + ". Your remaining balance is: " + balance);
            }
            else
            {
                Console.WriteLine("You have no such balance for this withdraw!!");
            }
        }

        public void Add_History(string message)
        {
            transactions.Add(message);
        }

        public void DisplayHistory()
        {
            for (int i = 0; i < transactions.Count; i++)
            {
                Console.WriteLine((i + 1) +": " + transactions[i]);
            }
        }
    }
}
