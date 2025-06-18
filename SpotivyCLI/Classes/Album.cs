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

        public Album(List<Artist> artist, string name, List<Song> songs) : base(name) { }

        public List<Artist> ShowArtist() {
            throw new NotImplementedException();
        }
        public override string ToString() {
            return base.ToString();
        }

    }
}
