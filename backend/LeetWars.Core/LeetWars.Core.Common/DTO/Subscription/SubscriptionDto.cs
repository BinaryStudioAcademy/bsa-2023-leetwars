using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.Common.DTO.Subscription
{
    public class SubscriptionDto : Entity<long>
    {
        public long UserId { get; set; }
        public string PaymentSubscriptionId { get; set; } = string.Empty;
        public int TypeId { get; set; }
        public decimal Cost { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime SubscribedDate { get; set; }
        public DateTime? UnsubscribedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
