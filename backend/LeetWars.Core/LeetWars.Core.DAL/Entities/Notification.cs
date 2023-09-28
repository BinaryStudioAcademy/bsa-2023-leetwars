using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.DAL.Entities
{
    public class Notification : Entity<long>
    {
        public long? SenderId { get; set; }
        public long? ChallengeId { get; set; }
        public long? FriendshipId { get; set; }
        public string? Message { get; set; }
        public TypeNotifications TypeNotification { get; set; }
        public DateTime DateSending { get; set; }
        public User? Sender { get; set; }
        public Challenge? Challenge { get; set; }
        public Friendship? Friendship { get; set; }
    }
}
