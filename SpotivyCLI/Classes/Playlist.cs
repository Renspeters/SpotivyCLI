using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotivyCLI.Classes
{
    class Playlist : SongCollection
    {
        public Person Owner { get; set; }

        public Playlist(Person person, string name) : base(name) {
            Owner = new Person(name);
        }

        public void Add(iPlayable playAble) { }
        public void Remove(iPlayable playAble) { }
        public override string ToString() { }
    }
}
