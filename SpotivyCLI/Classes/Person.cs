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
        public List<Person> ShowFriends() {
            throw new NotImplementedException();
        }
        public List<Playlist> ShowPlaylists() {
            throw new NotImplementedException();
        }
        public Playlist SelectPlaylist() {
            throw new NotImplementedException();
        }
        public void AddFriend() {
            throw new NotImplementedException();
        }
        public override string ToString() {
            return base.ToString();
        }
    }
}
