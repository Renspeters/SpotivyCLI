using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotivyCLI.Classes
{
    class SongCollection : iPlayable
    {
        public string Title { get; set; }
        private List<iPlayable> playables { get; set; }
        public int Length { get; set; }

        public SongCollection(string title) {
            Title = title;
            playables = new List<iPlayable>();
        }

        public override string ToString() {
            return base.ToString();
        }

        public List<iPlayable> ShowPlayables() {
            throw new NotImplementedException();
        }

        public void Play() {
            throw new NotImplementedException();
        }

        public void Pause() {
            throw new NotImplementedException();
        }

        public void Next() {
            throw new NotImplementedException();
        }

        public void Stop() {
            throw new NotImplementedException();
        }
    }
}
