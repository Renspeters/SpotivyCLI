using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotivyCLI.Classes
{
    class SuperUser
    {
        public void AddFriend(Person person) { }
        public void RemoveFriend(Person person) { }
        public Playlist CreatePlaylist(string CreatePlaylist) {
            throw new NotImplementedException();
        }
        public void RemovePlaylist(int index) { }
        public void AddToPlaylist(iPlayable playAble) { }
        public void RemoveFromPlaylist(iPlayable playAble) { }
    }
}
