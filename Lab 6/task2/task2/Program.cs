using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Song
    {
        private string Name;
        private string Singer;
        
        public Song(string name, string singer)
        {
            this.Name = name;
            this.Singer = singer;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"->  Song Name: {this.Name}\t Singer Name: {this.Singer}");
        }
    }

    internal class Playlist
    {
        private string Name;
        private List<Song> List;

        public Playlist(string name)
        {
            this.Name = name;
            this.List = new List<Song>();
        }

        public void AddSong(Song song)
        {
            List.Add(song);
        }

        public void PrintPlaylist()
        {
            Console.WriteLine($"Name of Playlist: {this.Name}");
            foreach (var s in List)
            {
                s.PrintDetails();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Song s1 = new Song("Song-1", "Singer-1");
            Song s2 = new Song("Song-2", "Singer-2");
            Song s3 = new Song("Song-3", "Singer-3");

            Playlist p1 = new Playlist("Palylist-1");
            Playlist p2 = new Playlist("Palylist-2");

            p1.AddSong(s1);
            p1.AddSong(s3);
            p2.AddSong(s3);
            p2.AddSong(s2);
            p2.AddSong(s1);

            p1.PrintPlaylist();
            p2.PrintPlaylist();
            Console.ReadKey();
        }
    }
}
