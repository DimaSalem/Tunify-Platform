namespace Tunify_Platform.Models
{
    public class Song
    {
        public int Id { get; set; }//PK
        public string Title { get; set; }
        public int Artist_ID { get; set; }//FK
        public int Album_ID { get; set; }//FK
        public string Duration { get; set; }
        public string Gener { get; set; }
        public Artist Artist { get; set; }
        public Album Album { get; set; }
        public ICollection<PlaylistSong> PlaylistSongs { get; set; }
    }
}
