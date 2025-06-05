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
    class Song 
    {
        public string Title { get; set; }
        public List<Artist> Artist { get; set; }
        public Genre SongGenre;

        private int Duration { get; set; }

        public Song(string name, List<Artist> artists, int index, Genre genre) { }

        public override string ToString() {
            return base.ToString();
        }
    }
}
