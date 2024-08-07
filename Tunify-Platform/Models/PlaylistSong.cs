namespace Tunify_Platform.Models
{
    public class PlaylistSong
    {
        public int Id { get; set; }//PR
        public int Playlist_ID { get; set; }//FK
        public int Song_ID { get; set; }//FK 
    }

}
