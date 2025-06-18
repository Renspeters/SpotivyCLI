using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotivyCLI.Classes
{
    class Artist
    {
        public string Name { get;  set; }
        private List<Album> Albums { get; set; }
        //private List<Song> Songs { get; set; }
        public Artist(string name, List<Album> albums) {
            Name = name;
            Albums = albums;
        }
        public void AddSong() { }
        public void AddAlbum() { }
        public override string ToString() {
            return Name;
        }
    }
}
