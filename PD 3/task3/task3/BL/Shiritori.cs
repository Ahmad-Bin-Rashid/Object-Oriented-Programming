using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Shiritori
    {
        public List<string> words;
        public bool game_over;

        public Shiritori()
        {
            words = new List<string>();
            game_over = false;
        }

        public List<string> Play(string word)
        {
            if (!game_over)
            {
                if (words.Count == 0 || word.ToLower()[0] == words[words.Count - 1].ToLower()[words[words.Count - 1].ToLower().Length - 1] && !words.Contains(word.ToLower()))
                {
                    words.Add(word.ToLower());
                    return words;
                }
                else
                {
                    game_over = true;
                    Console.WriteLine("Game Over! Invalid word.");
                }
            }
            else
            {
                Console.WriteLine("Game Over! The game has already ended.");
            }

            return new List<string>();
        }

        public string Restart()
        {
            words.Clear();
            game_over = false;
            return "Game restarted.";
        }
    }
}
