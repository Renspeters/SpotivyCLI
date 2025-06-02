using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotivyCLI.Classes
{
    class Person
    {
        public string Name { get; set; }
        private List<Person> Friends { get; set; }
        private List<Playlist> Playlists { get; set; }

        public Person(string name) { }
        public List<Person> ShowFriends() { }
        public List<Playlist> ShowPlaylists() { }
        public Playlist SelectPlaylist() { }
        public void AddFriend() { }
        public override string ToString() {}
    }
}
