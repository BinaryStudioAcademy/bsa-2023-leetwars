using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.DAL.Entities
{
    public class SubscriptionType : Entity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public BillingPeriod BillingPeriod { get; set; }

        public SubscriptionType(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
