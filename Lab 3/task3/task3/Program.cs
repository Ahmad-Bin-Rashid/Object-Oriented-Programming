using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM account = new ATM();
            Console.WriteLine("Balance on initializing account." + account.CheckBalance());
            account.Deposit(50000);
            Console.WriteLine("Balance after deposit." + account.CheckBalance());
            account.Withdraw(15000);
            Console.WriteLine("Balance after withdrawal." + account.CheckBalance());
            Console.WriteLine("Transaction history: ");
            account.DisplayHistory();
            Console.ReadKey();
        }
    }
}
