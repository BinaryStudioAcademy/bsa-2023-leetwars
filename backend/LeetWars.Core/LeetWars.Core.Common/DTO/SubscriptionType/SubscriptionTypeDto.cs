using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.SubscriptionType
{
    public class SubscriptionTypeDto : Entity<int>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Cost { get; set; }
        public BillingPeriod BillingPeriod { get; set; }
    }
}
