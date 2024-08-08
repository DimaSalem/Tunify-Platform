namespace Tunify_Platform.Models
{
    public class Artist
    {
        public int ID { get; set; }//PK
        public string Name { get; set; }
        public string Bio { get; set; }
        public ICollection<Song> Songs { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}
