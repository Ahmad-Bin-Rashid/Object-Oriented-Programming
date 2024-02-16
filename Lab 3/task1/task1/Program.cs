using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction trans1 = AddFirstTransaction();
            Transaction trans2 = new Transaction(trans1);

            trans2.id = "A2";
            Console.WriteLine(trans1.id);
            Console.WriteLine(trans1.productName);
            Console.WriteLine(trans1.amount);
            Console.WriteLine(trans1.date);
            Console.WriteLine(trans1.time);
            Console.WriteLine(trans2.id);
            Console.WriteLine(trans2.productName);
            Console.WriteLine(trans2.amount);
            Console.WriteLine(trans2.date);
            Console.WriteLine(trans2.time);
            Console.ReadKey();
        }

        static Transaction AddFirstTransaction()
        {
            Transaction trans = new Transaction();
            Console.Write("Enter Transaction Id: ");
            trans.id = Console.ReadLine();
            Console.Write("Enter Product Name: ");
            trans.productName = Console.ReadLine();
            Console.Write("Enter Transaction Amount: ");
            trans.amount = double.Parse(Console.ReadLine());
            Console.Write("Enter Transaction Date: ");
            trans.date = Console.ReadLine();
            Console.Write("Enter Transaction Time: ");
            trans.time = Console.ReadLine();
            return trans;
        }


    }
}
