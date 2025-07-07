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
        protected List<Playlist> Playlists { get; set; }

        public Person(string name) {
            Name = name;
            Friends = new List<Person>();
            Playlists = new List<Playlist>();
        }
        public List<Person> ShowFriends() {
            throw new NotImplementedException();
        }
        public List<Playlist> ShowPlaylists() {
            throw new NotImplementedException();
        }
        public Playlist SelectPlaylist(int index) {
            return Playlists[index];
        }

        public void AddFriend() {
            throw new NotImplementedException();
        }
        public override string ToString() {
            return base.ToString();
        }
    }
}
