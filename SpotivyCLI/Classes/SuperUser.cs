using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotivyCLI.Classes
{
    class SuperUser : Person
    {
        public SuperUser(string name) : base(name)
        {
        }

        public void AddFriend(Person person) { }
        public void RemoveFriend(Person person) { }
        public Playlist CreatePlaylist(string Title) {
            Playlist playlist = new Playlist(this, Title);
            Playlists.Add(playlist);
            return playlist;
        }
        public void RemovePlaylist(int index)
        {
            if (index >= 0 && index < Playlists.Count)
            {
                var playlist = Playlists[index];
                Console.WriteLine($" Playlist: '{playlist.Title}' removed");
                Playlists.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Ongeldig");
            }
        }
        public void AddToPlaylist(iPlayable playAble) { }
        public void RemoveFromPlaylist(iPlayable playAble) { }
    }
}
