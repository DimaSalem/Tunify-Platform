namespace Tunify_Platform.Models
{
    public class PlaylistSong
    {
        public int Playlist_ID { get; set; }//FK
        public int Song_ID { get; set; }//FK 
        public Playlist Playlist { get; set; }
        public Song Song { get; set; }
    }

}
