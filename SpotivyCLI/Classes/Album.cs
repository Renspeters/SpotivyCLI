using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotivyCLI.Classes
{
    class Album : SongCollection
    {
        private List<Artist> Artist { get; set; }

        public Album(List<Artist> artists, string name, List<Song> songs) : base(name) { }

        public List<Artist> ShowArtist() {
            return Artist;
        }
        public override string ToString() {
            return base.ToString();
        }

    }
}
