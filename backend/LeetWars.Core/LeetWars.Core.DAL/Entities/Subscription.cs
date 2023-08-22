namespace LeetWars.Core.DAL.Entities
{
    public class Subscription : Entity<long>
    {
        public long UserId { get; set; }
        public string PaymentSubscriptionId { get; set; }
        public int TypeId { get; set; }
        public decimal Cost { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime SubscribedDate { get; set; }
        public DateTime? UnsubscribedDate { get; set; }
        public bool IsActive { get; set; }
        public SubscriptionType? SubscriptionType { get; set; }

        public Subscription(string paymentSubscriptionId)
        {
            PaymentSubscriptionId = paymentSubscriptionId;
        }
    }
}
