using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EZInput;

namespace task6
{
    internal class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            Player player = new Player('P', 25, 10);
            Enemy enemy = new Enemy('E', rand.Next(10, 20), rand.Next(10, 20));
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Magenta;
            PrintMaze();
            PrintEnemy(enemy);
            PrintPlayer(player);
            while (true)
            {
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    ErasePlayer(player);
                    player.MoveLeft();
                    PrintPlayer(player);
                }
                else if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    ErasePlayer(player);
                    player.MoveRight();
                    PrintPlayer(player);
                }
                else if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    ErasePlayer(player);
                    player.MoveUp();
                    PrintPlayer(player);
                }
                else if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    ErasePlayer(player);
                    player.MoveDown();
                    PrintPlayer(player);
                }

                if (CheckColision(player, enemy))
                {
                    EraseEnemy(enemy);
                    enemy.SetPosition();
                    PrintEnemy(enemy);
                    PrintPlayer(player);
                    player.ScoreIncrement();
                }

                if (player.score >= 100)
                {
                    Console.Clear();
                    DisplayVictory();
                    Console.Read();
                    return;
                }

                Thread.Sleep(100);
                DisplayScore(player);
            }
            
        }

        static void PrintMaze()
        {
            
            Console.WriteLine("###########################################################");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("###########################################################");
        }

        static void PrintPlayer(Player p)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(p.x, p.y);
            Console.WriteLine(p.displayChar);
        }
        static void ErasePlayer(Player p)
        {
            Console.SetCursorPosition(p.x, p.y);
            Console.WriteLine(" ");
        }

        static bool CheckColision(Player p, Enemy e)
        {
            if (p.x == e.x && p.y == e.y)
            {
                return true;
            }
            return false;
        }

        static void PrintEnemy(Enemy e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(e.x, e.y);
            Console.WriteLine(e.displayChar);
        }
        static void EraseEnemy(Enemy e)
        {
            Console.SetCursorPosition(e.x, e.y);
            Console.WriteLine(" ");
        }

        static void DisplayScore(Player p)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(30, 20);
            Console.WriteLine("Score: " + p.score);
        }

        static void DisplayVictory()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("###########################################################");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                    Y O U   A R E                      ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                  V I C T O R I O U S                  ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("##                                                       ##");
            Console.WriteLine("###########################################################");
        }
    }
}
