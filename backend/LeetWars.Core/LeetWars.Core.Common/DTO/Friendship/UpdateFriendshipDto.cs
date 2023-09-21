using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.Friendship
{
    public class UpdateFriendshipDto
    {
        public long UserId { get; set; }
        public long FriendshipId { get; set; }
        public FriendshipStatus FriendshipStatus { get; set; }

        public UpdateFriendshipDto(long userId, long friendshipId, FriendshipStatus friendshipStatus)
        {
            UserId = userId;
            FriendshipId = friendshipId;
            FriendshipStatus = friendshipStatus;
        }
    }
}
