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
            if(CurrentlyPlaying == null) // Als er geen nummer wordt afgespeeld, 
            {
                Console.WriteLine("No song active");
                return;
            }
            Song current = CurrentlyPlaying as Song; //Nummer dat zich afspeelt
            int index = AllSongs.IndexOf(current);
            if (index == -1) // controleert of er nog een nummer in de lijst zit
            {
                Console.WriteLine("Song not found");
                return;
            }
            if (index + 1 < AllSongs.Count) // Als er nog een ander numer in de lijst zit, speelt het zich af
            {
                CurrentlyPlaying = AllSongs[index + 1];
                CurrentTime = 0;
                Playing = true;
                Console.WriteLine("Next Song:");
                CurrentlyPlaying.Play();
            } else if (Repeat){ // Als Repeat true is, dan speelt de lijst opnieuw vanaf het begin
                CurrentlyPlaying = AllSongs[0];
                CurrentTime = 0;
                Console.WriteLine("Repeat from begin:");
                CurrentlyPlaying.Play();
            }
            else
            {
                Playing = false;
                Console.WriteLine("End of list");
            }
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
