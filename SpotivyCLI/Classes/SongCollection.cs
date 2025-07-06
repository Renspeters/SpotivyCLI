using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotivyCLI.Classes
{
    enum Player {
        PLAYING,
        PAUSED,
    }
    class SongCollection : iPlayable
    {
        public string Title { get; set; }
        private List<iPlayable> playables { get; set; }
        private iPlayable? playingSong = null;
        private Player? player = null;
        private int length;
        public int Length { get { return length; } set { length = value; } }

        public SongCollection(string name) {
            Title = name;
            playables = new List<iPlayable>();
        }

        public List<iPlayable> ShowPlayables() {
            return playables;
        }

        public void Play() {
            throw new NotImplementedException();
        }

        public void Pause() {
            Console.WriteLine("Has been paused!");
            player = Player.PAUSED;
        }

        public void Next() {
            throw new NotImplementedException();
        }

        public void Stop() {
            Console.WriteLine("Has been stopped");
            playingSong = null;
            player = null;
        }
    }
}
