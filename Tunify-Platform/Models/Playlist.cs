namespace Tunify_Platform.Models
{
    public class Playlist
    {
        public int Id { get; set; } // PK
        public int User_ID { get; set; } // FK
        public string Playlist_Name { get; set; }
        public DateTime Created_Date { get; set; }
        public ICollection<PlaylistSong> PlaylistSongs { get; set; }
        public User User { get; set; }
    }
}
