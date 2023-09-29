using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.DAL.Entities
{
    public class Friendship : Entity<long>
    {
        public DateTime CreatedAt { get; set; }
        public FriendshipStatus Status { get; set; }

        public ICollection<UserFriendship> UserFriendships { get; } = new List<UserFriendship>();
        public ICollection<User> Users { get; } = new List<User>();

        public Friendship() { }

        public Friendship(DateTime createdAt, FriendshipStatus status)
        {
            CreatedAt = createdAt;
            Status = status;
        }
    }
}
