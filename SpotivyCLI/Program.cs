using SpotivyCLI.Classes;

namespace SpotivyCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var artist = new Artist("Rihanna", new List<Album>());
            var song = new Song("Diamonds", new List<Artist> { artist }, 215, Genre.POP);

            var client = new Client(new List<Person>(), new List<Album>(), new List<Song>());
            client.CurrentlyPlaying = song;
            client.Playing = true;

            client.NextSong();

        }

    }
}
