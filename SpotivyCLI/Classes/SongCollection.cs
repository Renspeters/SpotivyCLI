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

        public SongCollection(string name) {
            Title = name;
            playables = new List<iPlayable>();
        }

        public override string ToString() {
            return base.ToString();
        }

        public List<iPlayable> ShowPlayables() {
            throw new NotImplementedException();
        }
    }
}
