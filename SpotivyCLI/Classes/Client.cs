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
        public List<Song> AllSongs { get; set; }
        private List<Person> AllUsers;

        public Client(List<Person> person, List<Album> album, List<Song> song) { }
        public void SetActiveUser() { }
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
        public void NextSong() {
            if(CurrentlyPlaying == null)
            {
                Console.WriteLine("No song active");
                return;
            }
            if(CurrentlyPlaying is SongCollection){
                CurrentlyPlaying.Next();
            }
            else
            {
                CurrentlyPlaying.Play();
            }
                CurrentTime = 0;
            Playing = true;
        }
        public void SetShuffle() { }
        public void SetRepeat() { }
        public void CreatePlaylist() { }
        public void ShowPlaylists() { }
        public void SelectPlaylist() { }
        public void RemovePlaylist() { }
        public void AddToPlaylist() { }
        public void ShowSongsInPlaylist() { }
        public void RemoveFromPlaylist() { }
        public void ShowFriends() { }
        public void SelectFriend() { }
        public void AddFriend() { }
        public void RemoveFriend() { }
    }
}
