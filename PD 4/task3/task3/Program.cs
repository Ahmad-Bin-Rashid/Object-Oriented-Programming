using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static List<Player> players = new List<Player>();
        static List<Stats> skillStatistics = new List<Stats>();
        static void Main(string[] args)
        {

            int choice;

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Player");
                Console.WriteLine("2. Add Skill Statistics");
                Console.WriteLine("3. Display Player Info");
                Console.WriteLine("4. Learn a Skill");
                Console.WriteLine("5. Attack");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice (1-6): ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddPlayer();
                            break;

                        case 2:
                            AddSkillStatistics();
                            break;

                        case 3:
                            DisplayPlayerInfo();
                            break;

                        case 4:
                            LearnSkill();
                            break;

                        case 5:
                            Attack();
                            break;

                        case 6:
                            Console.WriteLine("Exiting the program.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                Console.WriteLine();
            } while (choice != 6);

        }

        static void AddPlayer()
        {
            Console.Write("Enter player name: ");
            string name = Console.ReadLine();
            Console.Write("Enter health: ");
            double health = double.Parse(Console.ReadLine());
            Console.Write("Enter max health: ");
            double maxHealth = double.Parse(Console.ReadLine());
            Console.Write("Enter energy: ");
            double energy = double.Parse(Console.ReadLine());
            Console.Write("Enter max energy: ");
            double maxEnergy = double.Parse(Console.ReadLine());
            Console.Write("Enter armor: ");
            double armor = double.Parse(Console.ReadLine());

            Player player = new Player(name, health, energy, armor)
            {
                maxHp = maxHealth,
                maxEnergy = maxEnergy
            };

            players.Add(player);
            Console.WriteLine($"{name} added successfully.");
        }

        static void AddSkillStatistics()
        {
            Console.Write("Enter skill name: ");
            string name = Console.ReadLine();
            Console.Write("Enter damage: ");
            double damage = double.Parse(Console.ReadLine());
            Console.Write("Enter penetration: ");
            double penetration = double.Parse(Console.ReadLine());
            Console.Write("Enter heal: ");
            double heal = double.Parse(Console.ReadLine());
            Console.Write("Enter cost: ");
            double cost = double.Parse(Console.ReadLine());
            Console.Write("Enter description: ");
            string description = Console.ReadLine();

            Stats stats = new Stats(name, damage, penetration, heal, cost, description);
            skillStatistics.Add(stats);
            Console.WriteLine($"{name} added to skill statistics successfully.");
        }

        static void DisplayPlayerInfo()
        {
            Console.WriteLine("Player Information:");
            foreach (var player in players)
            {
                Console.WriteLine($"Name: {player.name}, Health: {player.hp}/{player.maxHp}, Energy: {player.energy}/{player.maxEnergy}, Armor: {player.armor}");
            }
        }

        static void LearnSkill()
        {
            Console.Write("Enter player name: ");
            string playerName = Console.ReadLine();
            Console.Write("Enter skill name: ");
            string skillName = Console.ReadLine();

            Player player = players.Find(p => p.name.Equals(playerName, StringComparison.OrdinalIgnoreCase));
            Stats stats = skillStatistics.Find(s => s.skillname.Equals(skillName, StringComparison.OrdinalIgnoreCase));

            if (player != null && stats != null)
            {
                player.LearnSkill(stats);
                Console.WriteLine($"{playerName} learned {skillName} successfully.");
            }
            else
            {
                Console.WriteLine("Player or skill not found.");
            }
        }

        static void Attack()
        {
            Console.WriteLine("Choose attacking player:");
            DisplayPlayerInfo();
            Console.Write("Enter attacking player name: ");
            string attackerName = Console.ReadLine();

            Console.WriteLine("Choose target player:");
            DisplayPlayerInfo();
            Console.Write("Enter target player name: ");
            string targetName = Console.ReadLine();

            Player attacker = players.Find(p => p.name.Equals(attackerName, StringComparison.OrdinalIgnoreCase));
            Player target = players.Find(p => p.name.Equals(targetName, StringComparison.OrdinalIgnoreCase));

            if (attacker != null && target != null)
            {
                string result = attacker.Attack(target);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Attacker or target not found.");
            }
        }
        
    }
}
