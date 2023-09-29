using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.Common.DTO.Friendship
{
    public class FriendshipPreviewDto
    {
        public long FriendshipId { get; set; }
        public long FriendId { get; set; }
        public FriendshipStatus FriendshipStatus { get; set; }
    }
}
