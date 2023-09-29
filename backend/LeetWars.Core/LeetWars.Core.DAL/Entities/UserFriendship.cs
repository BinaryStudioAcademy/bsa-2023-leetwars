namespace LeetWars.Core.DAL.Entities
{
    public class UserFriendship
    {
        public long UserId { get; set; }
        public long FriendshipId { get; set; }
        public bool IsSender { get; set; }

        public Friendship? Friendship { get; set; }
        public User? User { get; set; }

        public UserFriendship() { }

        public UserFriendship(long userId, long friendshipId, bool isSender)
        {
            UserId = userId;
            FriendshipId = friendshipId;
            IsSender = isSender;
        }
    }
}
