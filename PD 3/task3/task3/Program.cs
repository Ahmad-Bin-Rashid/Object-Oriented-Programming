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
            Shiritori myShiritori = new Shiritori();

            Console.WriteLine(string.Join(", ", myShiritori.Play("apple")));
            Console.WriteLine(string.Join(", ", myShiritori.Play("ear")));
            Console.WriteLine(string.Join(", ", myShiritori.Play("rhino")));
            Console.WriteLine(string.Join(", ", myShiritori.Play("corn")));
            Console.WriteLine(string.Join(", ", myShiritori.Play("peach")));

            Console.WriteLine(string.Join(", ", myShiritori.Restart()));
            Console.WriteLine(string.Join(", ", myShiritori.Play("hostess")));
            Console.WriteLine(string.Join(", ", myShiritori.Play("stash")));
            Console.WriteLine(string.Join(", ", myShiritori.Play("hostess")));
            Console.ReadKey();
        }
    }
}
