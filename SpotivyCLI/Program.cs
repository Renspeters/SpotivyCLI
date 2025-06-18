using SpotivyCLI.Classes;

namespace SpotivyCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            testPlaySong();
        }

        public static void testPlaySong()
        {
            var artist = new Artist("Eminem", new List<Album>());
            var song = new Song("Lose Yourself", new List<Artist> { artist }, 326, Genre.HIPHOP);

            song.Play();
        }
    }
}
