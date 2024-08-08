namespace Tunify_Platform.Models
{
    public class Album
    {
        public int ID { get; set; }//PK
        public string Album_Name { get; set; }
        public DateTime Release_Date { get; set; }
        public int Artist_ID { get; set; }//FK
        public ICollection<Song>Songs { get; set; }
        public Artist Artist { get; set; }

    }
}
