using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Transaction
    {
        public Transaction() {}
        public Transaction(Transaction transaction)
        {
            id = transaction.id;
            productName = transaction.productName;
            amount = transaction.amount;
            date = transaction.date;
            time = transaction.time;
        }

        public string id;
        public string productName;
        public double amount;
        public string date;
        public string time;
    }
}
