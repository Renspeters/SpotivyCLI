using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotivyCLI.Classes
{
    class SongCollection
    {
        public string Title { get; set; }
        private List<iPlayable> playables { get; set; }

        public SongCollection(string name) { }

        public override string ToString() {
            List<string> songNames = new List<string>();

            foreach (iPlayable playable in playables)
            {
                var songName = playable.ToString();
                if (songName != null)
                {
                    songNames.Add(songName);
                }
            }

            string SongCollection = string.Join(", ", songNames);
            return SongCollection;
        }

        public List<iPlayable> ShowPlayables() {
            throw new NotImplementedException();
        }
    }
}
