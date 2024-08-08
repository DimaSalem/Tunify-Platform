namespace Tunify_Platform.Models
{
    public class Subscription
    {
        public int Id { get; set; }//PK
        public string SubscriptionType { get; set; }
        public double Price { get; set; }
    }
}
