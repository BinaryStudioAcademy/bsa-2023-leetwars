namespace LeetWars.Core.Common.DTO.Subscription
{
    public class SubscriptionNewDto
    {
        public long UserId { get; set; }
        public string PaymentSubscriptionId { get; set; } = string.Empty;
        public int TypeId { get; set; }
        public decimal Cost { get; set; }
    }
}
