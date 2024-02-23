using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player alice = new Player("Alice", 110, 50, 10);
            Player bob = new Player("Bob", 100, 60, 20);
            Stats fireball = new Stats("Fireball", 23, 1.2, 5, 15, "a firey magical attack.");
            alice.LearnSkill(fireball);
            Stats superbeam = new Stats("Superbeam", 200, 50, 50, 75, "an overpowered attack.");
            bob.LearnSkill(superbeam);
            Console.WriteLine(alice.Attack(bob));
            Console.WriteLine(bob.Attack(alice));
            Console.ReadKey();
        }
    }
}
