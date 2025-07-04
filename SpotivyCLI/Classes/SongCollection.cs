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
        private int length;
        public int Length { get { return length; } set { length = value; } }

        public SongCollection(string name) { }

        public override string ToString() {
            return base.ToString();
        }

        public List<iPlayable> ShowPlayables() {
            throw new NotImplementedException();
        }
    }
}
