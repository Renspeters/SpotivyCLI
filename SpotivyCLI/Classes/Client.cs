using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotivyCLI.Classes
{
    class Client
    {
        public iPlayable CurrentlyPlaying { get; set; }
        public int CurrentTime { get; set; }
        public bool Playing { get; set; }
        public bool Shuffle { get; set; }
        public bool Repeat { get; set; }

        private SuperUser ActiveUser;
        private List<Album> AllAlbums;
        public List<Song> AllSongs { get; private set; }
        private List<Person> AllUsers;

        public Client(List<Person> person, List<Album> album, List<Song> song) {
            AllUsers = person;
            AllAlbums = album;
            AllSongs = song;
        }
        public void SetActiveUser() {
            // Zoek eerste SuperUser in lijst AllUsers
            ActiveUser = AllUsers.OfType<SuperUser>().FirstOrDefault();

            if (ActiveUser == null)
            {
                Console.WriteLine("No SuperUser founded. Can not add a active user");
            }
            else
            {
                Console.WriteLine($"Active user added: {ActiveUser.Name}");
            }
        }
        public void ShowAllAlbums() { }
        public void SelectAlbum() { }
        public void ShowAllSongs() { }
        public void SelectSong() { }
        public void ShowAllUsers() { }
        public void SelectUser() { }
        public void ShowUserPlaylists() { }
        public void SelectUserPlaylist() { }
        public void Play() { }
        public void Pause() { }
        public void Stop() { }
        public void NextSong() { }
        public void SetShuffle() { }
        public void SetRepeat() { }
        public void CreatePlaylist()
        {
            Console.Write("Add a name for a new playlist: ");
            string title = Console.ReadLine();

            Playlist playlist = ActiveUser.CreatePlaylist(title);

            Console.WriteLine($"Playlist '{playlist.Title}' added.");
        }
        public void ShowPlaylists() { }
        public void SelectPlaylist(int index)
        {
            if(index < 0)
            {
                Console.WriteLine("index cannot be lower than 0");
            }
            var playlist = ActiveUser.SelectPlaylist(index);
            if (playlist != null)
            {
                Console.WriteLine($"Selected playlist: '{playlist.Title}'");
            }
        }
        public void RemovePlaylist() {
            ActiveUser.RemovePlaylist(0);
        }
        public void AddToPlaylist() { }
        public void ShowSongsInPlaylist() { }
        public void RemoveFromPlaylist() { }
        public void ShowFriends() { }
        public void SelectFriend() { }
        public void AddFriend() { }
        public void RemoveFriend() { }
    }
}
