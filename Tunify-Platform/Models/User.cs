namespace Tunify_Platform.Models
{
    public class User
    {
        public int Id { get; set; }//PK
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime Join_Date { get; set; }
        public int Subscription_ID { get; set; }//FK
    }
}
