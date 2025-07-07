using SpotivyCLI.Classes;
using System.Reflection;

namespace SpotivyCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperUser super = new SuperUser("Rens");
            var client = new Client(new List<Person> { super }, new List<Album>(), new List<Song>());
            client.SetActiveUser(); // stel de actieve gebruiker in (zelf schrijven)
            client.CreatePlaylist();
            client.SelectPlaylist(0);
            client.RemovePlaylist();
        }
    }
}
