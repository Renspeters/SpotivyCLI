using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotivyCLI.Classes

{
    enum Genre
    {
       ROCK,
       HIPHOP,
       JAZZ,
       METAL,
       BLUES,
       SOUL,
       BLUEGRASS,
       ELECTRONIC,
       CLASSIC,
       POP,
       FUNK

    }
    class Song : iPlayable
    {
        public string Title { get; set; }
        public List<Artist> Artists { get; set; }
        public Genre SongGenre;

        private int? Duration = null;
        private int length;
        public int Length { get { return length; } set { length = value; } }

        public Song(string title, List<Artist> artists, int length, Genre genre) {
            Title = title;
            Artists = artists;
            Length = length;
            SongGenre = genre;
        }

        public override string ToString() {
            return base.ToString();
        }

        public void Play()
        {
            Console.WriteLine($"Speelt nu: {Title}");
            Console.WriteLine($"Genre: {SongGenre}");
            Console.WriteLine($"Artiest(en):");
            foreach(var artist in Artists)
            {
                Console.WriteLine($"- {artist}");
            }
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Next()
        {
            throw new NotImplementedException();
        }

        public void Stop() {
            Console.WriteLine("Stopped playing!");
            Duration = null;
        }
    }
}
