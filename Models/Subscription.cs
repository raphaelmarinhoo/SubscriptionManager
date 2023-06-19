namespace SubscriptionManager.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
